using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class User :IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
    }
}
