using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class BaseModel
    {

        public string CreatedBy { get; set; }

        public DateTime Createddate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifedDate { get; set; }

        public  BaseModel()
        {
            this.Createddate = DateTime.Now;
            this.ModifedDate = DateTime.Now;
        }

    }
}
