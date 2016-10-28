using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MyProject.PancakeRevenge
{
    class PancakeRevenge
    {
        private static Stack st = new Stack();

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Derek\\Documents\\CodeJam\\PancakeRevenge\\B-small-practice");
            StreamWriter sw = new StreamWriter("C:\\Users\\Derek\\Documents\\CodeJam\\PancakeRevenge\\outSmall.txt");
            int testCases = 0;
            String str = null;

            str = sr.ReadLine();
            int.TryParse(str, out testCases);
            for ( int i = 0; i < testCases; i++ )
            {
                str = sr.ReadLine();
                stackPancakes(str);
                flipPancakes();
            }
        }

        public static void stackPancakes(String pancakeStack)
        {
            Stack temp = new Stack();
            char ch;

            var pancakes = pancakeStack.ToCharArray();
            foreach ( char p in pancakes )
            {
                temp.Push(p);
            }
            while ( temp.Count > 0 )
            {
                ch = (char)temp.Pop();
                st.Push(ch);
            }
        }

        public static void flipPancakes()
        {
            char sideUp = (char)st.Pop();
            Pancake pan = new MyProject.PancakeRevenge.Pancake(sideUp);
        }
    }
}
