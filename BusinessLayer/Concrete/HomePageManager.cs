using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomePageManager : IHomePageService
    {
        private readonly IHomePageDal _homePageDal;

        public HomePageManager(IHomePageDal HomePageDal)
        {
            _homePageDal = HomePageDal;
        }

        public void TDelete(HomePage t)
        {
            _homePageDal.Delete(t);
        }

        public HomePage TGetByID(int id)
        {
            return _homePageDal.GetByID(id);
        }

        public List<HomePage> TGetList()
        {
            return _homePageDal.GetList();
        }

        public List<HomePage> TGetListByFilter(Expression<Func<HomePage, bool>> filter)
        {
            return _homePageDal.GetListByFilter(filter);
        }

        public void TInsert(HomePage t)
        {
            _homePageDal.Insert(t);
        }

        public void TUpdate(HomePage t)
        {
            _homePageDal.Update(t);
        }
    }
}
