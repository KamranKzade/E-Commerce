using System;
using App.Core.Entities;

namespace App.Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipCountry { get; set; }
    }
}
