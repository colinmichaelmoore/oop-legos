namespace car_production_line
{
    public class Car

    {
        public Car()
        {
            
        }

        public Car(string color, string manufacturer)
        {
            this.Color = color;
            this.Manufacturer = manufacturer;

        }
        public string Color { get; set; }
        public string Manufacturer { get; set; }
    }
}