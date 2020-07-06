using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using study.automapper.Repository;
using study.automapper.Models;
namespace study.automapper.Data
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            this.CreateMap<StudentEntity, StudentModel>();
        }
    }
}
