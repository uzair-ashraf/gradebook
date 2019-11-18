using System;
using Xunit;

namespace gradebook.tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(95.5);
            book.AddGrade(65.7);
            book.AddGrade(90.8);
            var stats = book.GetStatistics();

            Assert.Equal(stats.High, 95.5, 1);
            Assert.Equal(stats.Low, 65.7, 1);
            Assert.Equal(stats.Average, 84, 1);
        }
    }
}
