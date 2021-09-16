using UserEntity = Fatec.Domain.Entities.User.User;

namespace Fatec.Domain.Entities.Address
{
    public class Address : Entity
    {
        public string CEP { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Complement { get; set; }
        public string Reference { get; set; }
        public UserEntity User { get; set; }
    }
}
