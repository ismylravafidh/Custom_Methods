using System;
using System.Text;
using System.Text.RegularExpressions;
//1.Contains(),Replace(),Substring(),Trim() methodlarını custom şəkildə yazmaq
//2.Person class-ı yaradırsız FullName, Age, PhoneNumber - property-ləri var FullName check
//(ən azı 2 sözdən ibarət olmalıdı ad və soyaddan hər ikisi böyük hərf-lə başlamalıdır )
//ps: Person yaradılarkən bütün dəyərlərin verilməsi məcburidir
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Ismayil Ceferov";
            int Age = 19;
            string PhoneNumber = "+994508964036";
            Person person = new Person(FullName,Age,PhoneNumber);

            string RegEx = "[A-Z]{1}[a-z]{2,25} [A-Z]{1}[a-z]{2,25}";
            Console.WriteLine(Regex.IsMatch(FullName , RegEx));


            MethodsCustom methodscustom = new MethodsCustom();

            string WordContains = "MyNameIsIsmayil";
            char wordcontains = 'a';
            methodscustom.CustomContains(WordContains, wordcontains);

            StringBuilder WordReplace = new StringBuilder("AsSalamAleykum");
            char wordreplace = 'a';
            char newwordreplace = 'b';
            methodscustom.CustomReplace(WordReplace , wordreplace, newwordreplace);

            string WordSubstring = "SalamDunya";
            int startindex = 0;
            int endindex = 5;
            methodscustom.CustomSubstring(WordSubstring , startindex, endindex);

            string WordTrim = "     Salam    Dunya    ";
            char wordtrimspacedelete = ' ';
            methodscustom.CustomTrim(WordTrim , wordtrimspacedelete);


        }
    }
}