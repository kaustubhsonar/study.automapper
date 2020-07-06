using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study.automapper.Repository
{
    public class StudentRepository
    {
        public List<StudentEntity> GetAllStudents()
        {
            return DataSource();
        }

        public StudentEntity GetStudentById
            (int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public StudentEntity SearchStudent(string rollNo)
        {
            return DataSource().Where(x => x.RollNo.Equals(rollNo)).FirstOrDefault();
        }

        private List<StudentEntity> DataSource()
        {
            return new List<StudentEntity>() {
            new StudentEntity(){ Id = 1 ,FirstName = "Tom" ,LastName="Johansson"  , RollNo = "101" },
            new StudentEntity(){ Id = 2 ,FirstName = "Tim" ,LastName="cook"  , RollNo = "102" },
            new StudentEntity(){ Id = 3 ,FirstName = "Daniel" ,LastName="Martin"  , RollNo = "103" },
            new StudentEntity(){ Id = 4 ,FirstName = "Hannah" ,LastName="Milger"  , RollNo = "104" },
            new StudentEntity(){ Id = 5 ,FirstName = "Karl" ,LastName="Johansson"  , RollNo = "105" },
            new StudentEntity(){ Id = 6 ,FirstName = "Tom" ,LastName="Underwood"  , RollNo = "106" }
            };
        }
    }
}
