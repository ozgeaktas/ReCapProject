using Core.Entities;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.Concreate
{
    public class Color:IEntities
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        
    }
}
