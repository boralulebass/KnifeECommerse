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
	public class BestSellerManager : IBestSellerService
	{
		private readonly IBestSellerDal _bestSellerDal;

		public BestSellerManager(IBestSellerDal bestSellerDal)
		{
			_bestSellerDal = bestSellerDal;
		}

		public List<BestSeller> IncludedBestSellers()
		{
			return _bestSellerDal.IncludedBestSellers();
		}

		public void TDelete(BestSeller t)
		{
			_bestSellerDal.Delete(t);
		}

		public BestSeller TGetByID(int id)
		{
			return _bestSellerDal.GetByID(id);
		}

		public List<BestSeller> TGetList()
		{
			return _bestSellerDal.GetList();
		}

		public List<BestSeller> TGetListByFilter(Expression<Func<BestSeller, bool>> filter)
		{
			return _bestSellerDal.GetListByFilter(filter);
		}

		public void TInsert(BestSeller t)
		{
			_bestSellerDal.Insert(t);
		}

		public void TUpdate(BestSeller t)
		{
			_bestSellerDal.Update(t);
		}
	}
}
