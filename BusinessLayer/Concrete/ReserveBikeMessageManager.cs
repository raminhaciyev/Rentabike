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
    public class ReserveBikeMessageManager : IReserveBikeMessageService
    {
        IReserveBikeMessageDal _reserveBikeMessageDal;

        public ReserveBikeMessageManager(IReserveBikeMessageDal reserveBikeMessageDal)
        {
            _reserveBikeMessageDal = reserveBikeMessageDal;
        }

        public void TAdd(ReserveBikeMessage t)
        {
            _reserveBikeMessageDal.Insert(t);
        }

        public void TDelete(ReserveBikeMessage t)
        {
            _reserveBikeMessageDal.Delete(t);
        }

        public List<ReserveBikeMessage> TGetBikeById(int id)
        {
            return _reserveBikeMessageDal.GetListByFilter(x =>x.BikeId == id);
        }

        public ReserveBikeMessage TGetById(int id)
        {
            return _reserveBikeMessageDal.GetById(id);
        }

        public List<ReserveBikeMessage> TGetList()
        {
            return _reserveBikeMessageDal.GetList();
        }

        public List<ReserveBikeMessage> TGetListMessageWithBike()
        {
            return _reserveBikeMessageDal.GetListMessageWithBike();
        }


        public void TUpdate(ReserveBikeMessage t)
        {
            _reserveBikeMessageDal.Update(t);
        }
    }
}
