using System;
using System.Collections.Generic;

namespace gradebook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("ligmabutt");// you are instantiating the book class you made
            book.AddGrade(95.5);
            book.AddGrade(65.7);
            book.AddGrade(90.8);
            book.GetStatistics();
        //     double x = 5454515.23;
        //     double y = 234234.23;
        //     var result = x + y;
        //     Console.WriteLine(result);

        //     if(args.Length > 0) {

        //         int totalGrades = args.Length;
        //         double gradeTotal = 0.0;
        //         double gradeAverage = 0.0;
        //         foreach(double grade in args) {
        //             gradeTotal += grade;
        //         }
        //         gradeAverage = totalGrades/gradeTotal;

        //         double[] numbers = new[] {12.1, 2.12, 4.123, 2342.2};

        //         List<double> grades = new List<double>();
        //         grades.Add(56.1);

        //         int totalGrades = grades.Capacity;

        //         double resultForArr = 0.0;

        //         foreach(double number in numbers) {
        //             resultForArr += number;
        //         }
        //         Console.WriteLine(resultForArr);
        // Console.WriteLine($"You inputted {totalGrades} grades. \n All your grades added together is {gradeTotal}. \n Your class average was {gradeAverage:N1}");
        //     } else {
        //         Console.WriteLine("You need to enter grades to find the data you need");
        //     }
        }
    }
}
