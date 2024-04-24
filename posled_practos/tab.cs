using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posled_practos
{
    internal class tab
    {
        public int camen_id;
        public int mesto_dobich;
        public int oxh;
        public int cena_id;

        public string nazvaine_kamni { get; private set; }
        public int cena_name { get; private set; }
        public string ochisj { get; private set; }
        public string mest_do { get; private set; }
        public tab(drag_camni ta)
        {
            camen_id = ta.id_camni;
            nazvaine_kamni = ta.name_camni;

            if (ta.mesto_dobich != null)
            {


                mesto_dobich = ta.mesto_dobich.id_dobich;
                mest_do = ta.mesto_dobich.mesto_dobich1;

            }
            if (ta.ochish_camen != null)
            {
                oxh = ta.ochish_camen.id_ochish;
                ochisj = ta.ochish_camen.ochish;

            }
            if (ta.cena_ukrash != null)
            {
                cena_id = ta.cena_ukrash.id_cena_ukrash;
                cena_name = (int)ta.cena_ukrash.priceee;
            }



        }


    }

}
