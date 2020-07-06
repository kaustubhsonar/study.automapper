using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study.automapper.Repository
{
    public class StudentEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String RollNo { get; set; }
    }
}
