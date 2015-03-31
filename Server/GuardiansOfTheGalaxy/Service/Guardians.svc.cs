using GuardiansOfTheGalaxy.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GuardiansOfTheGalaxy
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Guardians" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Guardians.svc or Guardians.svc.cs at the Solution Explorer and start debugging.
    public class Guardians : IGuardians
    {
        public string GetBoard(string id)
        {
            return "kaka: " + id;
        }


        public worker GetWorker(string id)
        {
            return PB.DB.workers.Find(id);
        }

        public string InitDB()
        {
            try
            {
                role rAdmin = new role();
                rAdmin.name = "admin";
                role rUser = new role();
                rUser.name = "user";

                PB.DB.roles.Add(rAdmin);
                PB.DB.roles.Add(rUser);

                return "ok" + PB.DB.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        public string DropDB()
        {
            throw new NotImplementedException();
        }


        public IQueryable<worker> SearchWorker(string param, string value)
        {
            Type t = typeof(worker);
            PropertyInfo propInfo = t.GetProperty(param);
            worker w = new worker();
            Object o = propInfo.GetValue(w);
            //propInfo.GetValue(x).ToString()
            return PB.DB.workers.Where(x => propInfo.GetValue(x).ToString() == value);
        }
    };
}
