using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindingJobDLL.Entities;
using FindingJobDLL.Repository.Abstractions;

namespace FindingJobDLL.Repository
{
    public class EmployeeAppliedForJobRepository:GenericRepository<EmployeeAppliedForJob>,IEmployeeAppliedForJobRepository
    {
        public EmployeeAppliedForJobRepository(FindingJobContext context):base(context)
        {

        }
    }
}
