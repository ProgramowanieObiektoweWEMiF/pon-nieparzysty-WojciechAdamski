using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCity2000
{
    class hotel : nieruchomosc
    {
        public hotel(string nazwa, int pokoje_kupione, int parkingi_kupione)
        {
            this.nazwa = nazwa;
            this.pokoje_kupione = pokoje_kupione;
            this.parkingi_kupione = parkingi_kupione;
        }



        public int pokoje_kupione;
        public int parkingi_kupione;




        public static int el1(int[, ,] c, int[,] d)
        {
            return c[d[2, 1], d[2, 2], d[1, 3]];

        }


        public static int el2(int[, ,] c, int[,] d)
        {
            return c[d[2, 1], d[2, 2] + 1, d[1, 3]];

        }


        public static string nazwaa(string[,] c, int[,] d)
        {
            return c[d[2, 1], d[1, 3]];

        }
    }
}
