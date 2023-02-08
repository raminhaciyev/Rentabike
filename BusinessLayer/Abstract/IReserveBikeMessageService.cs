using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReserveBikeMessageService : IGenericService<ReserveBikeMessage>
    {
        List<ReserveBikeMessage> TGetBikeById(int id);
        List<ReserveBikeMessage> TGetListMessageWithBike();
    }
}
