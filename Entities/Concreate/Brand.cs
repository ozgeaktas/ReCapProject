using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Brand:IEntities
    {
        public string BrandName { get; set; }
        public int BrandId { get; set; }
    }
}
