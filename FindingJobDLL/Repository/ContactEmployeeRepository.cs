using FindingJobDLL.Entities;
using FindingJobDLL.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingJobDLL.Repository
{
    public class ContactEmployeeRepository:GenericRepository<ContactEmployee>,IContactEmployeeRepository
    {
        public ContactEmployeeRepository(FindingJobContext context) : base(context)
        {
        }
    }
}
