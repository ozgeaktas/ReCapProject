using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class Customer:IEntities
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
