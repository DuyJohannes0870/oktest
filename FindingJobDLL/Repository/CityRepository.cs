using FindingJobDLL.Entities;
using FindingJobDLL.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingJobDLL.Repository
{ 
    public class CityRepository:GenericRepository<City>, ICityRepository
    {
        public CityRepository(FindingJobContext context):base(context)
        {           
        }
    }
}
