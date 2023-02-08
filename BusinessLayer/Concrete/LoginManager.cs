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
    public class LoginManager : ILoginService
    {
        ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public void TAdd(Login t)
        {
            _loginDal.Insert(t);
        }

        public void TDelete(Login t)
        {
            _loginDal.Delete(t);
        }

        public Login TGetById(int id)
        {
            return _loginDal.GetById(id);
        }

        public List<Login> TGetList()
        {
            return _loginDal.GetList();
        }

        public void TUpdate(Login t)
        {
            _loginDal.Update(t);
        }
    }
}
