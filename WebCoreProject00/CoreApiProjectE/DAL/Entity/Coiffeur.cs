using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiProjectE.DAL.Entity
{
    public class Coiffeur
    {
        [Key]
        public int ID { get; set; }
        public int CoiffeurID { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public int OperationID { get; set; }
        public int OperationTime { get; set; }
        public int Payment { get; set; }
        public string AuthorizedPerson { get; set; }
        public DateTime Date { get; set; }


    }
}
