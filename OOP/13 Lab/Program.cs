namespace Lab_13
{
    [Serializable]
    public class Transport
    {
        public string serial_number;

        public string origin_country;

        public string car_name;
    }

    [Serializable]
    public class Car : Transport
    {
        private const int capacity = 5;

        private const int max_speed = 200;

        [NonSerialized]
        public string color;

        public Car(string serial_number, string origin_country, string car_name)
        {
            this.serial_number = serial_number;
            this.origin_country = origin_country;
            this.car_name = car_name;
        }

        public Car()
        {}

        public string owner {get; set;}

        public string last_tech_osmotr {get;set;}
    }
}