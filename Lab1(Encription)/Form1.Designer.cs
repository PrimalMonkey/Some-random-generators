
namespace Lab1_Encription_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonLCG = new System.Windows.Forms.Button();
            this.buttonBBS = new System.Windows.Forms.Button();
            this.buttonLFSR = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGraphLCG = new System.Windows.Forms.Button();
            this.buttonGraphLFSR = new System.Windows.Forms.Button();
            this.buttonGraphBBS = new System.Windows.Forms.Button();
            this.buttonGrpah2LCG = new System.Windows.Forms.Button();
            this.buttonGrpah2BBS = new System.Windows.Forms.Button();
            this.buttonGraph2LFSR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewValues
            // 
            this.dataGridViewValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValues.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewValues.Name = "dataGridViewValues";
            this.dataGridViewValues.RowHeadersWidth = 51;
            this.dataGridViewValues.RowTemplate.Height = 24;
            this.dataGridViewValues.Size = new System.Drawing.Size(285, 426);
            this.dataGridViewValues.TabIndex = 0;
            this.dataGridViewValues.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewValues_RowPrePaint);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(462, 10);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSize.TabIndex = 1;
            this.numericUpDownSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(303, 12);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(153, 17);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Количество итераций";
            // 
            // buttonLCG
            // 
            this.buttonLCG.Location = new System.Drawing.Point(303, 32);
            this.buttonLCG.Name = "buttonLCG";
            this.buttonLCG.Size = new System.Drawing.Size(129, 33);
            this.buttonLCG.TabIndex = 4;
            this.buttonLCG.Text = "Выполнить LCG";
            this.buttonLCG.UseVisualStyleBackColor = true;
            this.buttonLCG.Click += new System.EventHandler(this.buttonLCG_Click);
            // 
            // buttonBBS
            // 
            this.buttonBBS.Location = new System.Drawing.Point(303, 71);
            this.buttonBBS.Name = "buttonBBS";
            this.buttonBBS.Size = new System.Drawing.Size(129, 33);
            this.buttonBBS.TabIndex = 5;
            this.buttonBBS.Text = "Выполнить BBS";
            this.buttonBBS.UseVisualStyleBackColor = true;
            this.buttonBBS.Click += new System.EventHandler(this.buttonBBS_Click);
            // 
            // buttonLFSR
            // 
            this.buttonLFSR.Location = new System.Drawing.Point(303, 110);
            this.buttonLFSR.Name = "buttonLFSR";
            this.buttonLFSR.Size = new System.Drawing.Size(153, 33);
            this.buttonLFSR.TabIndex = 6;
            this.buttonLFSR.Text = "Выполнить LFSR";
            this.buttonLFSR.UseVisualStyleBackColor = true;
            this.buttonLFSR.Click += new System.EventHandler(this.buttonLFSR_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(306, 149);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1027, 289);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // buttonGraphLCG
            // 
            this.buttonGraphLCG.Location = new System.Drawing.Point(615, 32);
            this.buttonGraphLCG.Name = "buttonGraphLCG";
            this.buttonGraphLCG.Size = new System.Drawing.Size(173, 33);
            this.buttonGraphLCG.TabIndex = 8;
            this.buttonGraphLCG.Text = "Частоты точек LCG";
            this.buttonGraphLCG.UseVisualStyleBackColor = true;
            this.buttonGraphLCG.Click += new System.EventHandler(this.buttonGraphLCG_Click);
            // 
            // buttonGraphLFSR
            // 
            this.buttonGraphLFSR.Location = new System.Drawing.Point(615, 110);
            this.buttonGraphLFSR.Name = "buttonGraphLFSR";
            this.buttonGraphLFSR.Size = new System.Drawing.Size(173, 33);
            this.buttonGraphLFSR.TabIndex = 9;
            this.buttonGraphLFSR.Text = "Частоты точек LFSR";
            this.buttonGraphLFSR.UseVisualStyleBackColor = true;
            this.buttonGraphLFSR.Click += new System.EventHandler(this.buttonGraphLFSR_Click);
            // 
            // buttonGraphBBS
            // 
            this.buttonGraphBBS.Location = new System.Drawing.Point(615, 71);
            this.buttonGraphBBS.Name = "buttonGraphBBS";
            this.buttonGraphBBS.Size = new System.Drawing.Size(173, 33);
            this.buttonGraphBBS.TabIndex = 10;
            this.buttonGraphBBS.Text = "Частоты точек BBS";
            this.buttonGraphBBS.UseVisualStyleBackColor = true;
            this.buttonGraphBBS.Click += new System.EventHandler(this.buttonGraphBBS_Click);
            // 
            // buttonGrpah2LCG
            // 
            this.buttonGrpah2LCG.Location = new System.Drawing.Point(794, 32);
            this.buttonGrpah2LCG.Name = "buttonGrpah2LCG";
            this.buttonGrpah2LCG.Size = new System.Drawing.Size(190, 33);
            this.buttonGrpah2LCG.TabIndex = 11;
            this.buttonGrpah2LCG.Text = "Вид на плоскости LCG";
            this.buttonGrpah2LCG.UseVisualStyleBackColor = true;
            this.buttonGrpah2LCG.Click += new System.EventHandler(this.buttonGrpah2LCG_Click);
            // 
            // buttonGrpah2BBS
            // 
            this.buttonGrpah2BBS.Location = new System.Drawing.Point(794, 71);
            this.buttonGrpah2BBS.Name = "buttonGrpah2BBS";
            this.buttonGrpah2BBS.Size = new System.Drawing.Size(190, 33);
            this.buttonGrpah2BBS.TabIndex = 12;
            this.buttonGrpah2BBS.Text = "Вид на плоскости BBS";
            this.buttonGrpah2BBS.UseVisualStyleBackColor = true;
            this.buttonGrpah2BBS.Click += new System.EventHandler(this.buttonGrpah2BBS_Click);
            // 
            // buttonGraph2LFSR
            // 
            this.buttonGraph2LFSR.Location = new System.Drawing.Point(794, 110);
            this.buttonGraph2LFSR.Name = "buttonGraph2LFSR";
            this.buttonGraph2LFSR.Size = new System.Drawing.Size(190, 33);
            this.buttonGraph2LFSR.TabIndex = 13;
            this.buttonGraph2LFSR.Text = "Вид на плоскости LFSR";
            this.buttonGraph2LFSR.UseVisualStyleBackColor = true;
            this.buttonGraph2LFSR.Click += new System.EventHandler(this.buttonGraph2LFSR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 450);
            this.Controls.Add(this.buttonGraph2LFSR);
            this.Controls.Add(this.buttonGrpah2BBS);
            this.Controls.Add(this.buttonGrpah2LCG);
            this.Controls.Add(this.buttonGraphBBS);
            this.Controls.Add(this.buttonGraphLFSR);
            this.Controls.Add(this.buttonGraphLCG);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonLFSR);
            this.Controls.Add(this.buttonBBS);
            this.Controls.Add(this.buttonLCG);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.dataGridViewValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonLCG;
        private System.Windows.Forms.Button buttonBBS;
        private System.Windows.Forms.Button buttonLFSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGraphLCG;
        private System.Windows.Forms.Button buttonGraphLFSR;
        private System.Windows.Forms.Button buttonGraphBBS;
        private System.Windows.Forms.Button buttonGrpah2LCG;
        private System.Windows.Forms.Button buttonGrpah2BBS;
        private System.Windows.Forms.Button buttonGraph2LFSR;
    }
}

