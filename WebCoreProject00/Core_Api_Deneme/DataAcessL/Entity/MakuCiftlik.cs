using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Api_Deneme.DataAcessL.Entity
{
    public class MakuCiftlik
    {
        [Key]
        public int ID { get; set; }
        public int SagımID { get; set; }
        public int HayvanID { get; set; }
        public int CiftlikID { get; set; }
        public int SutMiktari { get; set; }
        public int SagimSuresi { get; set; }
        public DateTime Date{ get; set; }
    }
}
