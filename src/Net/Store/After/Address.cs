namespace After
{
    public class Address
    {
        public string Street { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public Address(string street, string city, string country)
        {
            this.Street = street;
            this.City = city;
            this.Country = country;
        }
    }
}