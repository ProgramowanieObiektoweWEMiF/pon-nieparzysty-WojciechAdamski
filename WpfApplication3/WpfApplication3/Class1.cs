using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication3
{
    class stadion
    {
        public stadion(string nazwa_stadionu, int siedzenia_kupione, int sklepy_kupione)
        {
            this.nazwa_stadionu = nazwa_stadionu;
            this.siedzenia_kupione = siedzenia_kupione;
            this.sklepy_kupione = sklepy_kupione;
        }
        
        public string nazwa_stadionu;
        public int siedzenia_kupione;
        public int sklepy_kupione;


        public static int siedzenia_max = 200;
        public static int sklepy_max = 35;


    }
}
