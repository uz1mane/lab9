using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventgeneratingstats
{
    public partial class Form1 : Form
    {
        engine eng;
        public Form1()
        {
            InitializeComponent();
            eng = new engine(this);
            chart1.Series[0].Points.Clear();
            labelWarning.Visible = false;
        }

        private bool CheckValues()
        {
            double sum = (double)nudProb1.Value + (double)nudProb2.Value + (double)nudProb3.Value + (double)nudProb4.Value;

            if (sum < 1)
                return true;
            else
                return false;
        }

        public List<double> GetValues()
        {            
            List<double> values = new List<double>();            

            values.Add((double)nudProb1.Value);
            values.Add((double)nudProb2.Value);
            values.Add((double)nudProb3.Value);
            values.Add((double)nudProb4.Value);

            double sum = (double)nudProb1.Value + (double)nudProb2.Value + (double)nudProb3.Value + (double)nudProb4.Value;
            values.Add((double)1 - sum);
            
            values.Add((double)nudNumber.Value);                                 
            return values;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            labelWarning.Visible = false;
            if (CheckValues())
            {

                chart1.Series[0].Points.Clear();

                double[] stats = eng.Calculate();

                if (labelWarning.Visible == false)
                    for (int i = 0; i < stats.Length; i++)
                    {
                        chart1.Series[0].Points.AddY(stats[i]);
                    }
            }
            else
            {
                labelWarning.Visible = true;
                chart1.Series[0].Points.Clear();
            }
        }
    }
}
