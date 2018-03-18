using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core;
using CleanArchitecture.Core.SharedKernel;
using Newtonsoft.Json;

namespace CleanArchitecture.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public List<LabeledProperty> Email { get; set; }
        public List<LabeledProperty> Phone { get; set; }
        public int Company_Id { get; set; }

        [JsonProperty("15113600d066921ff8f99cc022a2084946df529c")]
        public string Description { get; set; }

        public string Org_Name { get; set; }
        public bool Active_Flag { get; set; }
    }

    public class LabeledProperty : BaseEntity
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public bool Primary { get; set; }
    }
}