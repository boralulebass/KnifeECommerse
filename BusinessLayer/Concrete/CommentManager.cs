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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TDelete(Comment t)
        {
           _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
           return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList().OrderByDescending(x=>x.CommentID).ToList();
        }

        public List<Comment> TGetListByFilter(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.GetListByFilter(filter);
        }

        public List<Comment> TIncludedComments()
        {
            return _commentDal.IncludedComments();
        }

        public void TInsert(Comment t)
        {
            t.Date = DateTime.Now;
            t.CommentStatus = false;
           _commentDal.Insert(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
