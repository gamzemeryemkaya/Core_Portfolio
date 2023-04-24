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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDAL _writermessageDal;

        public WriterMessageManager(IWriterMessageDAL writermessageDal)
        {
            _writermessageDal = writermessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writermessageDal.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writermessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writermessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writermessageDal.Delete(t);
        }

        public WriterMessage TGetByID(int id)
        {
            return _writermessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writermessageDal.GetList();
        }

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            _writermessageDal.Update(t);
        }
    }
}
