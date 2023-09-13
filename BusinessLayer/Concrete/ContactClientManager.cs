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
	public class ContactClientManager : IContactClientService
	{
		private readonly IContactClientDal _contactClientDal;

		public ContactClientManager(IContactClientDal contactClientDal)
		{
			_contactClientDal = contactClientDal;
		}

		public void TDelete(ContactClient t)
		{
			_contactClientDal.Delete(t);
		}

		public ContactClient TGetByID(int id)
		{
			return _contactClientDal.GetByID(id);	
		}

		public List<ContactClient> TGetList()
		{
			return _contactClientDal.GetList();
		}

		public List<ContactClient> TGetListByFilter(Expression<Func<ContactClient, bool>> filter)
		{
			return _contactClientDal.GetListByFilter(filter);
		}

		public void TInsert(ContactClient t)
		{
			t.Date= DateTime.Now;	
			_contactClientDal.Insert(t);
		}

		public void TUpdate(ContactClient t)
		{
			_contactClientDal.Update(t);
		}
	}
}
