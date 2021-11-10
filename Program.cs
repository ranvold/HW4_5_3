using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_5_3
{
    abstract class Triangle
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double AngleBetweenSides { get; set; }

        public abstract void CalcArea();
        public abstract void CalcPerimeter();

        public double DegreeToRadian(double degree)
        {
            return degree * Math.PI / 180;
        }
        public static bool ValidateSides(string firstSide, string secondSide, string angle)
        {
            bool valFlag = false;
            if ((firstSide != "" && secondSide != "" && angle != "") && (Convert.ToDouble(firstSide) > 0 
                && Convert.ToDouble(secondSide) > 0  && Convert.ToDouble(angle) > 0))
                valFlag = true;

            return valFlag;
        }
    }

    class RightTriangle : Triangle
    {
        public override void CalcArea()
        {
            Area = (FirstSide * SecondSide / 2) * Math.Sin(DegreeToRadian(AngleBetweenSides));
        }

        public override void CalcPerimeter()
        {
            if(AngleBetweenSides == 90)
            {
                Perimeter = FirstSide + SecondSide +
                    Math.Sqrt(FirstSide * FirstSide + SecondSide * SecondSide);
            }
            else if(FirstSide > SecondSide)
            {
                Perimeter = FirstSide + SecondSide +
                    Math.Sqrt(FirstSide * FirstSide - SecondSide * SecondSide);
            }
            else if(FirstSide < SecondSide)
            {
                Perimeter = FirstSide + SecondSide +
                    Math.Sqrt(SecondSide * SecondSide - FirstSide * FirstSide);
            }
        }
    }

    class IsoscelesTriangle : Triangle
    {
        public override void CalcArea()
        {
            Area = (FirstSide * SecondSide / 2) * Math.Sin(DegreeToRadian(AngleBetweenSides));
        }

        public override void CalcPerimeter()
        {
            if(FirstSide == SecondSide)
            {
                Perimeter = 2 * FirstSide + FirstSide * Math.Sqrt(2 - 2 * Math.Cos(DegreeToRadian(AngleBetweenSides)));
            }
            else if(SecondSide == 2 * FirstSide * Math.Cos(DegreeToRadian(AngleBetweenSides)))
            {
                Perimeter = 2 * FirstSide + SecondSide;
            }
            else
            {
                Perimeter = 2 * SecondSide + FirstSide;
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
