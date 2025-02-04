using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAx
{
    internal class GPAcal
    {
        private double gpa_sum = 0;
        private int n = 0;
        private double max = double.MinValue; 
        private double min = double.MaxValue; 
        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa; 
            this.n++;           

            if (gpa > max) 
            {
                max = gpa;
            }
            if (gpa <= min) 
            {
                min = gpa; 
            }
        }
        public double getGPAX()
        {
            return  Math.Round(this.gpa_sum / this.n, 2);
        }

        public double getMax()
        {
            return Math.Round(this.max, 2);
        }

        public double getMin()
        {
            return Math.Round(this.min, 2);
        }
    }
}

