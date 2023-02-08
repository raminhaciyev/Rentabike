using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReserveBikeMessageDal : GenericRepository<ReserveBikeMessage>, IReserveBikeMessageDal
    {
        public List<ReserveBikeMessage> GetListMessageWithBike()
        {
            using (var c = new Context())
            {
                return c.ReserveBikeMessages.Include(x => x.Bike).ToList();
            }
        }
    }
}
