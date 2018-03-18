using CleanArchitecture.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    public class Organization : BaseEntity
    {
        public int CompanyId { get; set; }
        public User Owner { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}
