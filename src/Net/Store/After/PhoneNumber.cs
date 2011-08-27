namespace After
{
    public class PhoneNumber
    {
        public string Number { get; private set; }

        public PhoneNumber(string number)
        {
            Number = number;
        }

        public string Format()
        {
            return string.Format("CountryCode:{0} - Citycode:{1} - LocalNumber:{2}",
                int.Parse(CountryCode),
                int.Parse(CityCode),
                int.Parse(LocalNumber));
        }

        private string LocalNumber
        {
            get
            {
                return this.Number.Substring(4);
            }
        }

        private string CityCode
        {
            get
            {
                return this.Number.Substring(2, 2);
            }
        }

        private string CountryCode
        {
            get
            {
                return this.Number.Substring(0, 2);
            }
        }
    }
}