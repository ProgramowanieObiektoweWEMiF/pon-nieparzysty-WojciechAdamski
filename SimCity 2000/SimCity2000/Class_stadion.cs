using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCity2000
{
    class stadion : nieruchomosc
    {
        public stadion(string nazwa_stadionu, int siedzenia_kupione, int sklepy_kupione)
        {
            this.nazwa = nazwa_stadionu;
            this.siedzenia_kupione = siedzenia_kupione;
            this.sklepy_kupione = sklepy_kupione;
        }


        public int siedzenia_kupione;
        public int sklepy_kupione;

    }
}
