using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Domain.Entities
{
    public class Vehicle
    {
        public Vehicle() { }


        [Column("id")]
        public int Id { get; private set; }

        [Column("plate")]
        public string Plate { get; private set; }

        [Column("brand")]
        public string Brand { get; private set; }
    }
}