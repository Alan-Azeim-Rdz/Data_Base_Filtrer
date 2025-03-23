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
            FromPlotFuel = new ScottPlot.WinForms.FormsPlot();
            FromPlotAspiration = new ScottPlot.WinForms.FormsPlot();
            FromPlotLosses = new ScottPlot.WinForms.FormsPlot();
            FromPlotDoors = new ScottPlot.WinForms.FormsPlot();
            FromPlotEngine = new ScottPlot.WinForms.FormsPlot();
            DagvTable = new DataGridView();
            BtnEnter = new Button();
            ComBoxElection = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DagvTable).BeginInit();
            SuspendLayout();
            // 
            // FromPlotFuel
            // 
            FromPlotFuel.DisplayScale = 1F;
            FromPlotFuel.Location = new Point(973, 32);
            FromPlotFuel.Name = "FromPlotFuel";
            FromPlotFuel.Size = new Size(219, 194);
            FromPlotFuel.TabIndex = 0;
            // 
            // FromPlotAspiration
            // 
            FromPlotAspiration.DisplayScale = 1F;
            FromPlotAspiration.Location = new Point(973, 261);
            FromPlotAspiration.Name = "FromPlotAspiration";
            FromPlotAspiration.Size = new Size(219, 194);
            FromPlotAspiration.TabIndex = 1;
            // 
            // FromPlotLosses
            // 
            FromPlotLosses.DisplayScale = 1F;
            FromPlotLosses.Location = new Point(1288, 32);
            FromPlotLosses.Name = "FromPlotLosses";
            FromPlotLosses.Size = new Size(219, 194);
            FromPlotLosses.TabIndex = 2;
            // 
            // FromPlotDoors
            // 
            FromPlotDoors.DisplayScale = 1F;
            FromPlotDoors.Location = new Point(1288, 261);
            FromPlotDoors.Name = "FromPlotDoors";
            FromPlotDoors.Size = new Size(219, 194);
            FromPlotDoors.TabIndex = 3;
            // 
            // FromPlotEngine
            // 
            FromPlotEngine.DisplayScale = 1F;
            FromPlotEngine.Location = new Point(1134, 461);
            FromPlotEngine.Name = "FromPlotEngine";
            FromPlotEngine.Size = new Size(219, 194);
            FromPlotEngine.TabIndex = 4;
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
            ComBoxElection.Items.AddRange(new object[] { "Toyota", "Nissan", "Mazda", "Mitsubishi", "Honda", "Volkswagen", "Subaru", "Peugot", "Volvo", "Dodge", "Mercedes-Benz", "BMW", "Audi", "Plymouth", "Saab", "Porsche", "Isuzu", "Jaguar", "Chevrolet", "Alfa Romeo", "Renault", "Mercury" });
            ComBoxElection.Location = new Point(187, 57);
            ComBoxElection.Name = "ComBoxElection";
            ComBoxElection.Size = new Size(210, 23);
            ComBoxElection.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1065, 14);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 8;
            label1.Text = "Fuel type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1065, 243);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Aspiration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1359, 14);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 10;
            label3.Text = "Normalized losses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1370, 243);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 11;
            label4.Text = "Num of Doors";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1198, 443);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 12;
            label5.Text = "Engine localitation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 669);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComBoxElection);
            Controls.Add(BtnEnter);
            Controls.Add(DagvTable);
            Controls.Add(FromPlotEngine);
            Controls.Add(FromPlotDoors);
            Controls.Add(FromPlotLosses);
            Controls.Add(FromPlotAspiration);
            Controls.Add(FromPlotFuel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DagvTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot FromPlotFuel;
        private ScottPlot.WinForms.FormsPlot FromPlotAspiration;
        private ScottPlot.WinForms.FormsPlot FromPlotLosses;
        private ScottPlot.WinForms.FormsPlot FromPlotDoors;
        private ScottPlot.WinForms.FormsPlot FromPlotEngine;
        private DataGridView DagvTable;
        private Button BtnEnter;
        private ComboBox ComBoxElection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
