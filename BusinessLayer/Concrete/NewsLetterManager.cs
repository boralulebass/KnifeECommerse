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
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal NewsLetterDal)
        {
            _newsLetterDal = NewsLetterDal;
        }

        public void TDelete(NewsLetter t)
        {
            _newsLetterDal.Delete(t);
        }

        public NewsLetter TGetByID(int id)
        {
            return _newsLetterDal.GetByID(id);
        }

        public List<NewsLetter> TGetList()
        {   
            return _newsLetterDal.GetList();
        }

        public List<NewsLetter> TGetListByFilter(Expression<Func<NewsLetter, bool>> filter)
        {
            return _newsLetterDal.GetListByFilter(filter);
        }

        public void TInsert(NewsLetter t)
        {
            _newsLetterDal.Insert(t);
        }

        public void TUpdate(NewsLetter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
