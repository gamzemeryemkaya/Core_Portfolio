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
    public class AnnouncementsManager : IGenericServices<Announcements>
    {
        IAnnouncmentsDAL _announcementsDal;

        public AnnouncementsManager(IAnnouncmentsDAL announcementsDal)
        {
            _announcementsDal = announcementsDal;
        }

        public void TAdd(Announcements t)
        {
            _announcementsDal.Insert(t);
        }

        public void TDelete(Announcements t)
        {
            _announcementsDal.Delete(t);
        }

        public Announcements TGetByID(int id)
        {
            return _announcementsDal.GetByID(id);
        }

        public List<Announcements> TGetList()
        {
            return _announcementsDal.GetList();
        }

        public List<Announcements> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcements t)
        {
            _announcementsDal.Update(t);
        }
    }
}
