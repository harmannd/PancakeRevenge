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
        private static int flips = 0;
        private static char smileyUp = '+';
        private static char smileyDown = '-';

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Derek\\Documents\\CodeJam\\PancakeRevenge\\B-large-practice.in");
            StreamWriter sw = new StreamWriter("C:\\Users\\Derek\\Documents\\CodeJam\\PancakeRevenge\\outLarge.txt");
            //StreamReader sr = new StreamReader("C:\\Users\\Derek\\Documents\\CodeJam\\PancakeRevenge\\input.txt");
            //StreamWriter sw = new StreamWriter("C:\\Users\\Derek\\Documents\\CodeJam\\PancakeRevenge\\output.txt");

            int testCases = 0;
            String str = null;
            int caseNum = 0;

            str = sr.ReadLine();
            int.TryParse(str, out testCases);
            for ( int i = 0; i < testCases; i++ )
            {
                caseNum = i + 1;
                str = sr.ReadLine();
                stackPancakes(str);
                flipPancakes();
                sw.WriteLine("Case #" + caseNum + ": " + flips);
                flips = 0;
            }
            sw.Flush();
            sw.Close();
            sr.Close();
        }

        public static void stackPancakes(String pancakeStack)
        {
            Stack temp = new Stack();
            Pancake pan;

            var pancakes = pancakeStack.ToCharArray();
            foreach ( char p in pancakes )
            {
                temp.Push(p);
            }
            while ( temp.Count > 0 )
            {
                pan = new Pancake((char)temp.Pop());
                st.Push(pan);
            }
        }

        public static void flipPancakes()
        {
            Pancake topPan;
            Pancake nextPan;
            Stack temp = new Stack();
            char panDirection;

            if ( st.Count == 1 )
            {
                topPan = (Pancake)st.Pop();
                panDirection = topPan.getSide();
                if ( panDirection.Equals(smileyDown) )
                    topPan.setSide(smileyUp);
                else
                    topPan.setSide(smileyDown);
                flips++;
                return;
            }
            while ( st.Count > 1 )
            {
                topPan = (Pancake)st.Pop();
                nextPan = (Pancake)st.Peek();
                if ( topPan.Equals(nextPan) )
                    temp.Push(topPan);
                else
                {
                    panDirection = topPan.getSide();
                    if ( panDirection.Equals(smileyDown) )
                        topPan.setSide(smileyUp);
                    else
                        topPan.setSide(smileyDown);
                    temp.Push(topPan);
                    flips++;
                }
            }
        }
    }
}
