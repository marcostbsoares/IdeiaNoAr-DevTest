using CleanArchitecture.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    class Organization : BaseEntity
    {
        public User Owner { get; set; }
        public string Name { get; set; }

    }
}
