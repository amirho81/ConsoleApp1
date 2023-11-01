
using System;
using System.Collections.Generic;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<(double grade, int unit)> courses = new List<(double grade, int unit)>();

            
            int n = 0;

            
            while (true)
            {
               
                Console.WriteLine("لطفا نمره و تعداد واحد یک درس را وارد کنید یا -1 را برای پایان ورودی بزنید:");
                Console.Write("نمره: ");
                double grade = double.Parse(Console.ReadLine());
                if (grade == -1) break; 
                Console.Write("تعداد واحد: ");
                int unit = int.Parse(Console.ReadLine());

                
                courses.Add((grade, unit));

                
                n++;
            }

            
            double weightedSum = 0;

            
            int totalUnits = 0;

            
            foreach (var course in courses)
            {
                weightedSum += course.grade * course.unit; 
                totalUnits += course.unit; 
            }

           
            double averageGrade = weightedSum / totalUnits; 

            
            Console.WriteLine($"میانگین {n} نمره دانشجو با احتساب تعداد واحد هر درس برابر است با: {averageGrade:F2}");
        }
    }
}
//امیرحسین جورابچی
//3.میانگین ۱۰ نمره دانشجو