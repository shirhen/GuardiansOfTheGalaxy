using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuardiansOfTheGalaxy
{
    public class WorkerComparer : IComparer<worker>
    {
        public int Compare(worker a, worker b)
        {
            if (a.rank.score > b.rank.score)
                return -1;
            else if (a.rank.score < b.rank.score)
                return 1;
            else return a.username.CompareTo(b.username) ;
        }
    }
}