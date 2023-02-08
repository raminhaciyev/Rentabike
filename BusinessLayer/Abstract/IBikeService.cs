using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBikeService: IGenericService<Bike>
    {
        List<Bike> GetListFalse();
        void DeleteTrue(Bike p);

    }
}
