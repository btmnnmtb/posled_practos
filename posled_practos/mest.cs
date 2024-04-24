using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posled_practos
{
    internal class mest
    {
        public int mesto_id;
        public int strna_id;
        public int post_id;
        public string stranaaa { get; private set; }
        public int postav { get; private set; }
        public string mestoooo { get; private set; }
        public mest(mesto_dobich mm)
        {
            mesto_id = mm.id_dobich;
            mestoooo = mm.mesto_dobich1;
            if (mm.strana != null)
            {
                strna_id = mm.strana.id_country_name;
                stranaaa = mm.strana.strana1;
            }
            if (mm.postavchik != null)
            {
                post_id = mm.postavchik.id_post;
                postav = mm.postavchik.id_post;

            }
        }

    }
}

