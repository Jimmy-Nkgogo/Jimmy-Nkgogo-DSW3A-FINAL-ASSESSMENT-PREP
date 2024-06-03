using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Create a class named Book that contains data fields for the title and number of pages. Include get and set
methods for these fields. Next, create a subclass named TextBook, which contains an additional field that
hold a grade level for the TextBook and additional methods to get and set the grade level field. Write an
application to demonstrates using objects of each class. Save the files as Book, TextBook and RunBook

             */
            Textbook textbook = new Textbook();
            textbook.setGradeLevel("A");
            textbook.setTitle("The Great Gatsby");
            textbook.setNumberOfPages(300);
            textbook.RunBook();
        }
    }
    abstract class Book
    {
        private string title;
        private int numberOfPages;

        
        public string getTitle()
        {
            return title;
        }
        public void setTitle(string Title)
        {
            this.title = Title;
        }
        
        public int getNumberOfPages()
        {
            return numberOfPages;
        }
        public void setNumberOfPages(int NumberOfPages)
        {
            this.numberOfPages = NumberOfPages;
        }
        public abstract void RunBook();
    }
    class Textbook : Book
    {
        private string gradeLevel;
        public Textbook()
        {
            
        }

        public string getGradeLevel()
        {
            return gradeLevel;
        }
        public void setGradeLevel(string GradeLevel)
        {
            this.gradeLevel = GradeLevel;
        }
        public override void RunBook()
        {
            Console.WriteLine($"{getTitle()} {getNumberOfPages()} {getGradeLevel()}");
        }
    }
}
