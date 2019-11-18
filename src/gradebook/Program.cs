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
        }
    }
}
