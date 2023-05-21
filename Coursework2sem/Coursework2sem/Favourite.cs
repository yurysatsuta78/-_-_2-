using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    internal class Favourite
    {
        int favid;
        int userid;
        int carid;
        public int Favid { get { return favid; } }
        public int Userid { get { return userid; } }
        public int Carid { get { return carid; } }
        public Favourite(int favid, int userid, int carid)
        {
            this.favid = favid;
            this.userid = userid;
            this.carid = carid;
        }
    }
}
