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

            #region 9th Question
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.
            int page = 464;
            bool isAvailable = true;

            if (page > 300 && isAvailable) // must two conditions are true to execute the statement
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region 10th Question
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            string bookTitle = "Refactoring";

            switch (bookTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!"); // switch enters only the case that matches the value of bookTitle and executes the statement
                    break;// break exits the switch  after executing the correct case

                default: // default case executed when no case matches the value of bookTitle
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region 11th Question
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            //variable sizeLabel(same rule as question 8: long if pages > 300).
            int price = 464;

            string sizeLabel = price > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);

            #endregion

            #region 12th Question
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            //to print each book with its position number, like 1.Clean Code.
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion

            #region 13th Question
            //Using the same books array, use a while loop to print every book title.
            string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            int index = 0;

            while (index < Books.Length) // when the condition is false the loop will stop executing and exit the loop
            {
                Console.WriteLine(Books[index]);
                index++;
            }
            #endregion

            #region 14th Question
            //Write a do-while loop that prints "Checking book..." exactly 3 times.
            int count = 0;

            do
            {
                Console.WriteLine("Checking book...");// the statement will execute at least once even if the condition is false 
                count++;

            } while (count < 3); // as long as the condition is true the loop will keep executing and when the condition is false it will exit the loop


            #endregion

        }
    }
}
