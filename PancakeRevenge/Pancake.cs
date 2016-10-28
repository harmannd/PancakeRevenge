using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.PancakeRevenge
{
    class Pancake
    {
        private char sideUp;

        public Pancake( char sUp )
        {
            sideUp = sUp;
        }

        private void setSide( char sUp )
        {
            sideUp = sUp;
        }

        private char getSide()
        {
            return sideUp;
        }
    }
}
