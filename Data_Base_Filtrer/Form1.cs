using ScottPlot;
using ScottPlot.WinForms;
using System.Data;
using System.Windows.Forms;

namespace Data_Base_Filtrer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fill_Table();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // Filtrar la tabla por la marca seleccionada
            string selectedBrand = ComBoxElection.Text;
            DataTable dt = (DataTable)DagvTable.DataSource;

            if (dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Make = '{selectedBrand}'";
                DataTable filteredTable = dv.ToTable();

                // Procesar datos de fuel-type y generar la gráfica
                ProcessData(filteredTable, "fuel-type", FromPlotFul);
                ProcessData(filteredTable, "aspiration", formsPlot2);
                ProcessData(filteredTable, "normalized-losses", formsPlot3);
            }


        }

        private void ProcessData(DataTable table, string columnName, FormsPlot plot)
        {
            // Contar los valores de la columna
            Dictionary<string, double> countData = new Dictionary<string, double>();

            foreach (DataRow row in table.Rows)
            {
                string value = row[columnName].ToString().Trim().ToLower(); // Normalizar el texto

                if (!string.IsNullOrEmpty(value))
                {
                    if (countData.ContainsKey(value))
                        countData[value]++;
                    else
                        countData[value] = 1;
                }
            }

            // Convertir los conteos a un arreglo de dobles
            double[] values = countData.Values.ToArray();
            string[] labels = countData.Keys.ToArray();

            // Llamar a la función para graficar
            Create_Pie_Table(values, labels, plot, columnName);
        }

      
        private void Create_Pie_Table(double[] values, string[] labels, FormsPlot plot, string title)
        {
            plot.Plot.Clear(); // Limpiar gráfico previo
            var pie = plot.Plot.Add.Pie(values);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 0.5;

            // Calcular porcentajes
            double total = values.Sum();
            double[] percentages = values.Select(x => x / total * 100).ToArray();

            // Etiquetas de los segmentos
            for (int i = 0; i < values.Length; i++)
            {
                pie.Slices[i].Label = $"{labels[i]} ({percentages[i]:0.0}%)";
                pie.Slices[i].LabelFontSize = 14;
                pie.Slices[i].LabelBold = true;
                pie.Slices[i].LabelFontColor = Colors.Black.WithAlpha(.7);
            }

            // Ajustar apariencia del gráfico
            plot.Plot.Title($"Distribución de {title}");
            plot.Plot.Axes.Frameless();
            plot.Plot.HideGrid();
            plot.Refresh();
        }

        private void Fill_Table()
        {
            // Leer un archivo CSV y mostrarlo en un DataGridView
            string path = @"C:\Users\1gren\Downloads\archive\Automobile_data.CSV";
            string[] lines = File.ReadAllLines(path);
            string[] headers = lines[0].Split(',');
            DataTable dt = new DataTable();

            foreach (string header in headers)
            {
                dt.Columns.Add(header.Trim());
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                DataRow row = dt.NewRow();
                for (int j = 0; j < headers.Length; j++)
                    row[j] = data[j];
                dt.Rows.Add(row);
            }

            // Asignar el DataTable al DataGridView
            DagvTable.DataSource = dt;
        }
    }

}

