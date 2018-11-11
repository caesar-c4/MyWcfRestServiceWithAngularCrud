using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int Insert(Employee employee)
        {
            using (DbModel db = new DbModel())
            {
                db.employee.Add(employee);
                return db.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetData()
        {
            using (DbModel db = new DbModel())
            {
                return db.employee.ToList();
            }
        }


        public void Update(Employee employee)
        {
            using (DbModel db = new DbModel())
            {
                db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }


        public void Delete(string id)
        {
            using (DbModel db = new DbModel())
            {
                db.employee.Remove(db.employee.Find(int.Parse(id)));
                db.SaveChanges();
            }
        }


        public Employee Edit(string id)
        {
            var r = int.Parse(id);
            using (DbModel db = new DbModel())
            {
                //return db.UserInfos.Find(int.Parse(id));
                return db.employee.Where(a => a.Id == r).SingleOrDefault();
            }

        }
    }
}
