namespace car_production_line
{
    public class SaloonCar : Car
    {
        public SaloonCar(int numberOfSeats)
        {
            this.NumberOfSeats = numberOfSeats;

        }

        public SaloonCar(int numberOfSeats, string manufacturer)
        {
            this.NumberOfSeats = numberOfSeats;
            this.Manufacturer = manufacturer;
        }

        public SaloonCar(int numberOfSeats, string manufacturer, string color)
        {

            this.NumberOfSeats = numberOfSeats;
            this.Manufacturer = manufacturer;
            this.Color = color;

        }
        
            
        

        public int NumberOfSeats { get; set; }
    }

    
}