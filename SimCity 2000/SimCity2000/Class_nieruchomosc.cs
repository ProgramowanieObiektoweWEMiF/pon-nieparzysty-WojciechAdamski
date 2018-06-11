using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCity2000
{
    class nieruchomosc
    {
        public string nazwa;
        public static int element1_max = 40;
        public static int element2_max = 100;




        public static int zysk_el1(int a)
        {
            return a * 2000;
        }

        public static int zysk_el2(int b)
        {
            return b * 400;
        }

        public static int wybor (int[,] c)
        {
            return c[1, 3];
        }

    }
}
