using CleanArchitecture.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    class Follower : BaseEntity
    {
        public int OrganizationId { get; set; }
        public DateTime AddTime { get; set; }
        public int UserId { get; set; }
    }
}
