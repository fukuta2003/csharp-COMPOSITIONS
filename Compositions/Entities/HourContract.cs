using System;

namespace Compositions.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract()
        {

        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double totalValue()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Date
                + ","
                + Hours
                + ","
                + ValuePerHour;
        }

    }
}
