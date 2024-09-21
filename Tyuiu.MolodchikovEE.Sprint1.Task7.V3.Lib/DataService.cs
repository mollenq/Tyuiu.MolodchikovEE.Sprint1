﻿using tyuiu.cources.programming.interfaces.Sprint1;



namespace Tyuiu.MolodchikovEE.Sprint1.Task7.V3.Lib
{
    public class DataService : ISprint1Task7V3
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round((3+Math.Exp(y-1))/(1+(Math.Pow(x,2)*Math.Abs(y-Math.Tan(x)))),3);
            return res;
        }
    }
}
