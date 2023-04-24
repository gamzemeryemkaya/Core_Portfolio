using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDAL _writeruserdal;

        public WriterUserManager(IWriterUserDAL writeruserdal)
        {
            _writeruserdal = writeruserdal;
        }

        public void TAdd(WriterUser t)
        {
            _writeruserdal.Insert(t);
        }

        public void TDelete(WriterUser t)
        {
            _writeruserdal.Delete(t);
        }

        public WriterUser TGetByID(int id)
        {
            return _writeruserdal.GetByID(id);
        }

        public List<WriterUser> TGetList()
        {
            return _writeruserdal.GetList();
        }

        public List<WriterUser> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            _writeruserdal.Update(t);
        }
    }
}
