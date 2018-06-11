using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCity2000
{
    class stadion : nieruchomosc
    {
        public stadion(string nazwa_stadionu, int lozevip_kupione, int sklepy_kupione)
        {
            this.nazwa = nazwa_stadionu;
            this.lozevip_kupione = lozevip_kupione;
            this.sklepy_kupione = sklepy_kupione;
        }



        public int lozevip_kupione;
        public int sklepy_kupione;




        public static int el1(int[, ,] c, int[,] d)
        {
            return c[d[1, 1], d[1, 2], d[1, 3]];

        }


        public static int el2(int[, ,] c, int[,] d)
        {
            return c[d[1, 1], d[1, 2]+1, d[1, 3]];

        }

    }
}
