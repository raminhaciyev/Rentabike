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
    public class MessageContactManager : IMessageContactService
    {
        IMessageContactDal _messageContactDal;

        public MessageContactManager(IMessageContactDal messageContactDal)
        {
            _messageContactDal = messageContactDal;
        }

        public void TAdd(MessageContact t)
        {
            _messageContactDal.Insert(t);
        }

        public void TDelete(MessageContact t)
        {
            _messageContactDal.Delete(t);
        }

        public MessageContact TGetById(int id)
        {
            return _messageContactDal.GetById(id);
        }

        public List<MessageContact> TGetList()
        {
            return _messageContactDal.GetList();
        }

        public void TUpdate(MessageContact t)
        {
            _messageContactDal.Update(t);
        }
    }
}
