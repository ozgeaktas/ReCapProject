using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreate
{
    public class Rental:IEntities
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
