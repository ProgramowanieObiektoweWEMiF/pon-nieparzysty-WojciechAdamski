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
    }
}
