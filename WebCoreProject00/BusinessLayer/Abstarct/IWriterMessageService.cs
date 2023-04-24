using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IWriterMessageService : IGenericServices<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessage(string p);
        List<WriterMessage> GetListReceiverMessage(string p);
    }
}
