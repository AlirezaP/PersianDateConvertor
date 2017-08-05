using System;

namespace PerstianDateConvertor
{
    public class PersianDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public double Millisecond { get; set; }


        public string DayOfWeekString
        {
            get
            {
                return Convertor.DayOfWeekString(GetDate());
            }
        }

        public DayOfWeek DayOfWeek
        {
            get
            {
                return Convertor.DayOfWeekend(GetDate());
            }
        }

        public PersianDate Now
        {
            get
            {
                var temp = DateTime.Now;
                return Convertor.ToPersianDate(temp);
            }
        }

        public override string ToString()
        {
            return $"{Year}/{Month}/{Day} {Hour}:{Minute}:{Second}";
        }

        private PersianDate GetDate()
        {
            return new PersianDate
            {
                Year = Year,
                Month = Month,
                Day = Day,

                Hour = Hour,
                Minute = Minute,
                Second = Second,
                Millisecond = Millisecond
            };
        }

    }
}
