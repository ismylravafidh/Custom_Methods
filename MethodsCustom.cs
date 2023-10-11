using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MethodsCustom
    {
        public void CustomContains(string WordContains, char word)
        {
            bool Contains = false;
            for (int i = 0; i < WordContains.Length; i++)
            {
                if (WordContains[i] == word)
                {
                    Contains = true;
                    break;
                }
            }
            Console.WriteLine(Contains);
        }

        public void CustomReplace(StringBuilder WordReplace, char wordreplace, char newwordreplace)
        {
            for (int i = 0; i < WordReplace.Length; i++)
            {

                if (WordReplace[i] == wordreplace)
                {
                    WordReplace[i] = newwordreplace;
                }
            }
            Console.WriteLine(WordReplace);
        }

        public void CustomSubstring(string WordSubstring, int startindex, int endindex)
        {
            for (int i = startindex; i < endindex; i++)
            {
                Console.Write(WordSubstring[i]);
            }
            Console.WriteLine();
        }

        public void CustomTrim(string WordTrim, char wordtrimspacedelete)
        {
            int startindex = 0;
            int endindex = WordTrim.Length - 1;
            for (int i = startindex; i < WordTrim.Length; i++)
            {
                if (WordTrim[i] == wordtrimspacedelete)
                {
                    startindex += 1;
                    continue;
                }
                else
                {
                    break;
                }
            }
            for (int i = endindex; i >= startindex; i--)
            {
                if (WordTrim[i] == wordtrimspacedelete)
                {
                    endindex -= 1;
                    continue;
                }
                else
                {
                    break;
                }
            }
            for (int i = startindex; i <= endindex; i++)
            {
                Console.Write(WordTrim[i]);
            }
        }
    }
}
