using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Lab1_Encription_
{
    public partial class Form1 : Form
    {

        private DataSet valuesDataSet = null;
        private DataTable valuesDataTable = null;
        private static int size = 100;
        private double[] arrLCG = new double[size];

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDataSet()
        {
            valuesDataTable = new DataTable("valuesTable");
            DataColumn ksiColumn = new DataColumn("values", typeof(double));
            valuesDataTable.Columns.Add(ksiColumn);
            dataGridViewValues.DataSource = valuesDataTable;
            dataGridViewValues.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewValues.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewValues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewValues.RowHeadersWidth = 55;
            DataGridViewColumn gridColumnValues = dataGridViewValues.Columns[0];
            gridColumnValues.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridColumnValues.ReadOnly = true;
            valuesDataSet = new DataSet("MyDataSet");
            valuesDataSet.Tables.Add(valuesDataTable);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDataSet();
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.Legends.Clear();

            
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(numericUpDownSize.Value);
        }

        private void dataGridViewValues_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            if (dataGridViewValues.Rows[index].IsNewRow)
            {
                return;
            }
            string rowIndexStr = (index + 1).ToString();
            object header = dataGridViewValues.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(rowIndexStr))
                dataGridViewValues.Rows[index].HeaderCell.Value = rowIndexStr;
        }

        private void buttonLCG_Click(object sender, EventArgs e)
        {
            valuesDataSet.Clear();
            for (int i = 0; i < size; i++)
            {
                var row = valuesDataTable.NewRow();
                valuesDataTable.Rows.Add(row);
            }

            var rng = new RandomNumberGeneratorLCG();
            double value = 0;

            for (int i = 0; i < valuesDataTable.Rows.Count; i++)
            {
                arrLCG[i] = rng.Next(size);
                value = arrLCG[i];
                dataGridViewValues.Rows[i].Cells[0].Value = value;
            }
        }

        private void buttonBBS_Click(object sender, EventArgs e)
        {
            valuesDataSet.Clear();
            for (int i = 0; i < size; i++)
            {
                var row = valuesDataTable.NewRow();
                valuesDataTable.Rows.Add(row);
            }

            double[] arr = new double[size];
            Methods.genBBS(size, 67, 127, arr);
            double value = 0;

            for (int i = 0; i < valuesDataTable.Rows.Count; i++)
            {
                value = arr[i];
                dataGridViewValues.Rows[i].Cells[0].Value = value;
            }
        }

        private void buttonLFSR_Click(object sender, EventArgs e)
        {
            valuesDataSet.Clear();
            for (int i = 0; i < size; i++)
            {
                var row = valuesDataTable.NewRow();
                valuesDataTable.Rows.Add(row);
            }

            double[] arr = new double[size];
            Methods.genLFSR(size, arr);
            double value = 0;

            for (int i = 0; i < valuesDataTable.Rows.Count; i++)
            {
                value = arr[i];
                dataGridViewValues.Rows[i].Cells[0].Value = value;
            }
        }

        private void buttonGraphLCG_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = size;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 10;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.Series[0].ChartType = SeriesChartType.Column;

            for (int i = 0; i < size * 1000; i++)
            {
                int freq = Methods.freq(arrLCG, i);
                chart1.Series[0].Points.AddXY(i, freq);
            }
        }

        private void buttonGraphLFSR_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 35;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 35;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 5;
            chart1.ChartAreas[0].AxisX.Crossing = -1;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            double[] arr = new double[size];
            Methods.genLFSR(size, arr);
            chart1.Series[0].ChartType = SeriesChartType.Column;
            
            for (int i = 0; i < 32; i++)
            {
                int freq = Methods.freq(arr, i);
                chart1.Series[0].Points.AddXY(i, freq);
            }

        }

        private void buttonGraphBBS_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 2;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 5;
            chart1.ChartAreas[0].AxisX.Crossing = -2;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            double[] arr = new double[size];
            Methods.genBBS(size, 67, 127, arr);
            chart1.Series[0].ChartType = SeriesChartType.Column;
            int x = 1;
            int y = 0;
            int freq1 = 0;
            int freq0 = 0;
            

                //Methods.to10((int)valueArr[])
            



            for (int i = 0; i < size; i++)
            {
                y = (int)arr[i];
                if(arr[i] == 1)
                {
                    freq1++;

                }
                else
                {
                    freq0++;
                }
            }
            chart1.Series[0].Points.AddXY(1, freq1);
            chart1.Series[0].Points.AddXY(0, freq0);
        }

        private void buttonGrpah2LCG_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 50;
            chart1.ChartAreas[0].AxisY.Interval = 50;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.Series[0].ChartType = SeriesChartType.Point;

            for (int i = 0; i < size - 1; i++)
            {
                chart1.Series[0].Points.AddXY(arrLCG[i], arrLCG[i + 1]);
            }

        }

        private void buttonGrpah2BBS_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 10;
            chart1.ChartAreas[0].AxisY.Interval = 10;
            chart1.ChartAreas[0].AxisX.Crossing = -2;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            double[] arr = new double[size];
            Methods.genBBS(size, 67, 127, arr);
            chart1.Series[0].ChartType = SeriesChartType.Point;

            string temp = Methods.BBSToGraph(arr); ;
            int i = 0;
            int j = 0;
            string test = "";
            int[] valueArr = new int[(arr.Length / 5)];
            char[] columnValue = new char[5];
            int[] columnValueInt = new int[5];
            while (i < arr.Length - 5)
            {
                test = temp.Substring(i, 5);
                i += 5;
                using (StringReader sr = new StringReader(test))
                {
                    sr.Read(columnValue, 0, test.Length);
                }
                for(int k = 0; k < columnValue.Length; k++)
                {
                    columnValueInt[k] = (int)Char.GetNumericValue(columnValue[k]);
                }

                int value10 = Methods.to10(columnValueInt);
                columnValue = new char[5];
                columnValueInt = new int[5];
                /*if(Convert.ToInt32(test) == 1000)
                {
                    valueArr[j] = 01000;
                    j++;
                }*/
                valueArr[j] = value10;
                j++;
            }

            for (int k = 0; k < valueArr.Length - 1; k++)
            {
                chart1.Series[0].Points.AddXY(valueArr[k], valueArr[k + 1]);
            }
            //int[] result = new int[valueArr.Length];
            /* for(int count = 0; count < result.Length; count++)
             {
                 int x = Methods.to10(valueArr);
                 result[count] = x;
             }
             for (int k = 0; i < size - 1; k++)
             {
                 chart1.Series[0].Points.AddXY(result[k], result[k + 1]);
             }*/

        }

        private void buttonGraph2LFSR_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Maximum = 35;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 35;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.Crossing = -1;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            double[] arr = new double[size];
            Methods.genLFSR(size, arr);
            chart1.Series[0].ChartType = SeriesChartType.Point;

            for (int i = 0; i < size - 1; i++)
            {
                chart1.Series[0].Points.AddXY(arr[i], arr[i + 1]);
            }
        }
    }
}
