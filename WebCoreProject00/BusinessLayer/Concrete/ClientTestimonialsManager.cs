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
    public class ClientTestimonialsManager : IGenericServices<ClientTestimonials>
    {
        IClientTestimonialsDAL _clientTestimonialsDal;

        public ClientTestimonialsManager(IClientTestimonialsDAL clientTestimonialsDal)
        {
            _clientTestimonialsDal = clientTestimonialsDal;
        }

        public void TAdd(ClientTestimonials t)
        {
            _clientTestimonialsDal.Insert(t);
        }

        public void TDelete(ClientTestimonials t)
        {
            _clientTestimonialsDal.Delete(t);
        }

        public ClientTestimonials TGetByID(int id)
        {
            return _clientTestimonialsDal.GetByID(id);
        }

        public List<ClientTestimonials> TGetList()
        {
            return _clientTestimonialsDal.GetList();
        }

        public List<ClientTestimonials> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ClientTestimonials t)
        {
            _clientTestimonialsDal.Update(t);
        }
    }
}
