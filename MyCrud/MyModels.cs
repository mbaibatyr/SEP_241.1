using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyCrud
{
    class MyModels
    {
    }

    public class StudentModel
    {
        public string id { get; set; }
        public string birthdate { get; set; }
        public string fi { get; set; }
        public string gender { get; set; }
    }

    public class StudentAddOrEditModel
    {
        public string id { get; set; }
        public DateTime birthdate { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
    }
}
