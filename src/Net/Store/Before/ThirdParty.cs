namespace Before
{
    public class ThirdParty
    {
        public string PhoneNumber { get; private set; }

        public string ContactName { get; set; }

        public ThirdParty(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public string FormatPhone()
        {
            return string.Format("CountryCode:{0} - Citycode:{1} - LocalNumber:{2}",
                int.Parse(this.PhoneNumber.Substring(0, 2)),
                int.Parse(this.PhoneNumber.Substring(2, 2)),
                int.Parse(this.PhoneNumber.Substring(4)));
        }
    }
}