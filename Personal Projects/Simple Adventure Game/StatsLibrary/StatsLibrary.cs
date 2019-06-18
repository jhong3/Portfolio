using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsLibrary
{
    class Character
    {
        private static int STR = 10;
        private static int HP = 25;
        private static int ENRG = 5;

        public static void CharacterStats(int STR1, int HP1, int ENRG1)
        {
            STR = STR1;
            HP = HP1;
            ENRG = ENRG1;
        }

        public int SetSTR
        {
            get { return STR; }
            set
            {
                if (value >= 1)
                {
                    STR = value;
                }
                else
                {
                    STR = 10;
                }
            }
        }
        public int SetHP
        {
            get { return 25; }
            set
            {
                if (value >= 1)
                {
                    HP = value;
                }
                else
                {
                    HP = 25;
                }
            }
        }
        public int SetENRG
        {
            get { return ENRG; }
            set
            {
                if (value >= 1)
                {
                    ENRG = value;
                }
                else
                {
                    ENRG = 5;
                }
            }
        }
    }
}
