using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Grapher
{
    public partial class Form1 : Form
    {
        int counter = 2;
        public Form1()
        {
            InitializeComponent();

            //chart1.Titles.Add("Your custom chart");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["1"].Points.AddXY(textBox2.Text, textBox1.Text);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                chart1.Series["1"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            else
                chart1.Series["1"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();

            chart1.Series.Add("1");

            if (checkBox1.Checked)
                chart1.Series["1"].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = comboBox1.SelectedIndex;
            switch (selection)
            {
                case 0:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
                    break;
                case 1:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
                    break;
                case 2:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
                    break;
                case 3:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
                    break;
                case 4:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
                    break;
                case 5:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
                    break;
                case 6:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
                    break;
                case 7:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
                    break;
                case 8:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
                    break;
                case 9:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
                    break;
                default:
                    chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
                    break;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imagePath = Environment.CurrentDirectory + "\\savedBarGraph.png";
            chart1.SaveImage(imagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            chart1.Series.Add("" + counter++);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = comboBox2.SelectedIndex;
            switch (selection)
            {
                case 0:
                    chart1.BackColor = System.Drawing.Color.White;
                    break;
                case 1:
                    chart1.BackColor = System.Drawing.Color.Salmon;
                    break;
                case 2:
                    chart1.BackColor = System.Drawing.Color.SeaShell;
                    break;
                case 3:
                    chart1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    break;
                case 4:
                    chart1.BackColor = System.Drawing.Color.PaleGreen;
                    break;
                case 5:
                    chart1.BackColor = System.Drawing.Color.Cyan;
                    break;
                case 6:
                    chart1.BackColor = System.Drawing.Color.Lavender;
                    break;
                case 7:
                    chart1.BackColor = System.Drawing.Color.Thistle;
                    break;
                default:
                    
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                chart1.BorderlineColor = System.Drawing.Color.Black;
            else
                chart1.BorderlineColor = System.Drawing.Color.Transparent;
        }
    }
}
