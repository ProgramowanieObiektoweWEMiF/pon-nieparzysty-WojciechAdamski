using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCity2000
{
    class centrum : nieruchomosc
    {
        public centrum(string nazwa, int restauracje_kupione, int automaty_kupione)
        {
            this.nazwa = nazwa;
            this.restauracje_kupione = restauracje_kupione;
            this.automaty_kupione = automaty_kupione;
        }



        public int restauracje_kupione;
        public int automaty_kupione;




        public static int el1(int[, ,] c, int[,] d)
        {
            return c[d[3, 1], d[3, 2], d[1, 3]];

        }


        public static int el2(int[, ,] c, int[,] d)
        {
            return c[d[3, 1], d[3, 2] + 1, d[1, 3]];

        }


        public static string nazwaa(string[,] c, int[,] d)
        {
            return c[d[3, 2], d[1, 3]];

        }

    }
}
