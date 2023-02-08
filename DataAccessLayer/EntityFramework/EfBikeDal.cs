using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBikeDal : GenericRepository<Bike>, IBikeDal
    {
        public List<Bike> GetListFalse()
        {
            using var c = new Context();
            return c.Set<Bike>().Where(x => x.Status == false).ToList();
        }

        public void DeleteTrue(Bike p)
        {
            using var c = new Context();
            p.Status = true;
            c.Update(p);
            c.SaveChanges();
        }
    }
}
