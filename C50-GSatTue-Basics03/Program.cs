using System.Drawing;

namespace C50_GSatTue_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion
            #region Question 02
            // Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            string title1 = "Clean Code";
            string title2 = "Clean Code";
            bool CheckReferenceEquals = ReferenceEquals(title1, title2);
            Console.WriteLine(CheckReferenceEquals);

            #endregion

        }
    }
}
