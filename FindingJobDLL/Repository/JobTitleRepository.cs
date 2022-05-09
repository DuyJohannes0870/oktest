using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindingJobDLL.Entities;
using FindingJobDLL.Repository.Abstractions;
namespace FindingJobDLL.Repository
{
    public class JobTitleRepository:GenericRepository<JobTitle>,IJobTitleRepository
    {
        private FindingJobContext _context;
        public JobTitleRepository(FindingJobContext context) : base(context)
        {

        }
    }
}
