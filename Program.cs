using System.Security.Cryptography;
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

        }
    }
}
