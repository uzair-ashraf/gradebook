using System.Collections.Generic;
using System;

namespace gradebook {
  public class Book
  {
    public Book(string name) {
      this.grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade) {
        grades.Add(grade);
    }
    public Statistics GetStatistics() {
      var result = new Statistics();
      result.High = double.MinValue;
      result.Low = double.MaxValue;
      foreach (double grade in grades) {
        result.Average += grade;
        result.High = Math.Max(grade, result.High);
        result.Low = Math.Min(grade, result.Low);
      }
      result.Average /= grades.Count;

      return result;
    }
    List<double> grades;
    string name;
  }
}
