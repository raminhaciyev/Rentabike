using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BikeManager : IBikeService
    {
        IBikeDal _bikeDal;

        public BikeManager(IBikeDal bikeDal)
        {
            _bikeDal = bikeDal;
        }

        public void DeleteTrue(Bike p)
        {
            _bikeDal.DeleteTrue(p);
        }

        public List<Bike> GetListFalse()
        {
            return _bikeDal.GetListFalse();
        }

        public void TAdd(Bike t)
        {
            _bikeDal.Insert(t);
        }

        public void TDelete(Bike t)
        {
            _bikeDal.Delete(t);
        }

        public Bike TGetById(int id)
        {
            return _bikeDal.GetById(id);
        }

        public List<Bike> TGetList()
        {
            return _bikeDal.GetList();
        }

        public void TUpdate(Bike t)
        {
            _bikeDal.Update(t);
        }
    }
}
