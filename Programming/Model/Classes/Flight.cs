using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeMinutes;
        public int FlightTimeMinutes
        {
            get { return _flightTimeMinutes; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Время полёта не может быть отрицательным.");
                _flightTimeMinutes = value;
            }
        }
        public string DeparturePoint { get; set; }
        public string Destination { get;set; }
        public Flight() { }
        public Flight(string departurePoint, string destination, int flightTimeMinutes)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }
    }
}
