using App.Core.Entities;



namespace App.Entities.Concrete
{
    public class ShippingDetails:IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
