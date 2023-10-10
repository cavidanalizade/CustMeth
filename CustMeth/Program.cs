//Contains(),Replace(),Substring(),Trim() methodlarını custom şəkildə yazmaq
namespace CustMeth
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String @string = new String();
            @string.name = "    Javidan    ";
/*            Console.WriteLine(@string.ContainMethod('I'));

            Console.WriteLine(@string.ReplaceMethod('a', 'i'));

            Console.WriteLine(@string.SubStringMethod(2));*/

            Console.WriteLine(@string.TrimMethod());


        }

    }
}