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

        public void setSide( char sUp )
        {
            sideUp = sUp;
        }

        public char getSide()
        {
            return sideUp;
        }

        public override bool Equals(object obj)
        {
            Pancake pan = obj as Pancake;
            if ( pan == null )
                return false;
            else
                return sideUp.Equals(pan.sideUp);
        }

        public override int GetHashCode()
        {
            return this.sideUp.GetHashCode();
        }
    }
}
