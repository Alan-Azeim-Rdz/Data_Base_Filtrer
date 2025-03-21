namespace Data_Base_Filtrer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FromPlotFul = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
            formsPlot5 = new ScottPlot.WinForms.FormsPlot();
            DagvTable = new DataGridView();
            BtnEnter = new Button();
            ComBoxElection = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DagvTable).BeginInit();
            SuspendLayout();
            // 
            // FromPlotFul
            // 
            FromPlotFul.DisplayScale = 1F;
            FromPlotFul.Location = new Point(973, 32);
            FromPlotFul.Name = "FromPlotFul";
            FromPlotFul.Size = new Size(219, 194);
            FromPlotFul.TabIndex = 0;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(973, 261);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(219, 194);
            formsPlot2.TabIndex = 1;
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(1288, 32);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(219, 194);
            formsPlot3.TabIndex = 2;
            // 
            // formsPlot4
            // 
            formsPlot4.DisplayScale = 1F;
            formsPlot4.Location = new Point(1288, 261);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(219, 194);
            formsPlot4.TabIndex = 3;
            // 
            // formsPlot5
            // 
            formsPlot5.DisplayScale = 1F;
            formsPlot5.Location = new Point(1134, 461);
            formsPlot5.Name = "formsPlot5";
            formsPlot5.Size = new Size(219, 194);
            formsPlot5.TabIndex = 4;
            // 
            // DagvTable
            // 
            DagvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DagvTable.Location = new Point(52, 136);
            DagvTable.Name = "DagvTable";
            DagvTable.Size = new Size(826, 502);
            DagvTable.TabIndex = 5;
            // 
            // BtnEnter
            // 
            BtnEnter.Location = new Point(89, 56);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(75, 23);
            BtnEnter.TabIndex = 6;
            BtnEnter.Text = "Enter";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // ComBoxElection
            // 
            ComBoxElection.FormattingEnabled = true;
            ComBoxElection.Items.AddRange(new object[] { "Toyota", "", "Nissan", "", "Mazda", "", "Mitsubishi", "Honda", "", "Volkswagen", "", "Subaru", "", "Peugot", "", "Volvo", "Dodge", "", "Mercedes-Benz", "BMW", "Audi", "", "Plymouth", "", "Saab", "", "Porsche", "", "Isuzu", "", "Jaguar", "", "Chevrolet", "", "Alfa Romeo", "", "Renault", "", "Mercury" });
            ComBoxElection.Location = new Point(187, 57);
            ComBoxElection.Name = "ComBoxElection";
            ComBoxElection.Size = new Size(210, 23);
            ComBoxElection.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 669);
            Controls.Add(ComBoxElection);
            Controls.Add(BtnEnter);
            Controls.Add(DagvTable);
            Controls.Add(formsPlot5);
            Controls.Add(formsPlot4);
            Controls.Add(formsPlot3);
            Controls.Add(formsPlot2);
            Controls.Add(FromPlotFul);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DagvTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot FromPlotFul;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot formsPlot4;
        private ScottPlot.WinForms.FormsPlot formsPlot5;
        private DataGridView DagvTable;
        private Button BtnEnter;
        private ComboBox ComBoxElection;
    }
}
