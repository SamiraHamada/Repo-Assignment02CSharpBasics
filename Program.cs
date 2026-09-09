using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Assignment02_C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Question
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
           // both title and upperTitle to show that title did not change.
            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine(title); //title did not change because string is immutable and original string is not changed
            Console.WriteLine(upperTitle);

            #endregion

            #region 2nd Question
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.
            string title01 = "Clean Code";
            string title02 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(title01, title02)); //the output is true because two variables point to the same object in heap
            #endregion

            #region 3rd Question
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
           StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb); //stringbuilder is mutable and can modify the same object in heap but string is immutable 
            #endregion

            #region 4th Question
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            StringBuilder Sbuilder = new StringBuilder();

            Sbuilder.Append("Book List");
            Sbuilder.Append(" - Updated");

            Sbuilder.Replace("Book List", "Library");

            Console.WriteLine(Sbuilder);

            #endregion

            #region 5th Question
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
           //Pages: 464" using the + operator.
            string Title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + Title + ", Pages: " + pages);
            #endregion

            #region 6th Question
            //Build the same sentence as above, but using string interpolation ($"...").
            Console.WriteLine($"Book: {Title}, Pages: {pages}");

            #endregion

            #region 7th Question
            //Build the same sentence again, but using string.Format().
            Console.WriteLine("Book: {0}, Pages: {1}", Title, pages);

            #endregion

            #region 8th Question
            //Given int Pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //300, otherwise prints "Short Book".
            int Pages = 464;

            if (Pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            } 
            #endregion
        }

    }

}
