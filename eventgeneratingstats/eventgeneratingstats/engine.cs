using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventgeneratingstats
{
    class engine
    {
        private Form1 form;
        Random rand = new Random();

        public engine(Form1 form)
        {
            this.form = form;
        }

        public double[] Calculate()
        {
            int[] numbers = new int[5];
            double[] stats = new double[5];

            List<double> values = form.GetValues();

            double prob1 = values[0];
            double prob2 = values[0] + values[1];
            double prob3 = values[0] + values[1] + values[2];
            double prob4 = values[0] + values[1] + values[2] + values[3];
            double prob5 = values[0] + values[1] + values[2] + values[3] + values[4];

            values[0] = prob1;
            values[1] = prob2;
            values[2] = prob3;
            values[3] = prob4;
            values[4] = prob5;

            int number = (int)values[5];
            values.RemoveAt(5);
            //values.Add(1);

            for (int i = 0; i < number; i++)
            {
                double answer = rand.NextDouble();

                for (int j = 0; j < values.Count; j++)
                {
                    if (answer - values[j] < 0)
                    {
                        answer = j;
                        break;
                    }
                }

                numbers[(int)answer]++;
            }

            for (int i = 0; i < 5; i++)
            {
                stats[i] = (double)numbers[i] / (double)number;
            }

            return stats;
        }
    }
}
