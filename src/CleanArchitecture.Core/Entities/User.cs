using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core.Events;
using CleanArchitecture.Core.SharedKernel;

namespace CleanArchitecture.Core.Entities
{
    class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool HasPic { get; set; }
        public string PicHash { get; set; }
        public bool ActiveFlag { get; set; }
        public int Value { get; set; }
    }
}


    //"owner_id": {
    //  "id": 4244175,
    //  "name": "Phillippe Santana",
    //  "email": "ps@ideianoar.com.br",
    //  "has_pic": false,
    //  "pic_hash": null,
    //  "active_flag": true,
    //  "value": 4244175
    //},