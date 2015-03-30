using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GuardiansOfTheGalaxy
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Guardians" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Guardians.svc or Guardians.svc.cs at the Solution Explorer and start debugging.
    public class Guardians : IGuardians
    {
        //public void DoWork()
        //{
        //}

        public string XMLData(string id)
        {
            return "kaka" + id;
        }

        public string JSONData(string id)
        {
            return "kaka" + id;
        }
    }
}
