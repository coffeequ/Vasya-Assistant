using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Реализация_проекта
{
    class ParametrsWinAndMan
    {
        public double A { get; set; }

        public double B { get; set; }

        private double d;

        public double D
        {
            get { return d; }
            set
            {
                byte minD = 30;
                if (value >= minD)
                {
                    d = value;
                }
                else
                {
                    MessageBox.Show("Диаметр головы, Васи, должен быть не менее 30");
                }
            }
            
        }

        //public ParametrsWinAndMan(double A, double B, double D)
        //{
        //    this.A = A;
        //    this.B = B;
        //    this.D = D;
        //}

        public string Calculation()
        {
            byte Gap = 1;
            byte minD = 30;
            if (A > 0 & B > 0 & D >= minD)
            {
                if (((A - Gap) * (B - Gap)) > D)
                {
                    return "Вася, сможет высунуть голову в окно";
                }
                else
                {
                    return "Вася, не сможет высунуть голову в окно";
                }
            }
            return "Значения не подходят";
        }

    }
}
