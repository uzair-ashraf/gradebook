using System.Collections.Generic;
using System;

namespace gradebook {
  class Book
  {
    public Book(string name) {
      this.grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade) {
        grades.Add(grade);
    }
    public void GetStatistics() {
      double result = 0.0;
      var highestValue = double.MinValue;
      var lowestValue = double.MaxValue;
      foreach (double grade in grades) {
        result += grade;
        highestValue = Math.Max(grade, highestValue);
        lowestValue = Math.Min(grade, lowestValue);
      }
      result /= grades.Count;
      Console.WriteLine($"Here are the results for {name}");
      Console.WriteLine($"The total amount of grades you entered were {grades.Count}");
      Console.WriteLine($"The average was {result}");
      Console.WriteLine($"The highest grade was {highestValue}");
      Console.WriteLine($"The lowest grade was {lowestValue}");

    }
    List<double> grades;
    string name;
  }
}
