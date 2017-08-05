using System;
using System.Globalization;

namespace PerstianDateConvertor
{
    public class Convertor
    {

        public static DateTime ToGregorianDate(PersianDate date)
        {
            PersianCalendar p = new PersianCalendar();
            return p.ToDateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, (int)date.Millisecond);
        }

        public static PersianDate ToPersianDate(DateTime date)
        {
            PersianCalendar p = new PersianCalendar();
            return new PersianDate
            {
                Day = p.GetDayOfMonth(date),
                Month = p.GetMonth(date),
                Year = p.GetYear(date),

                Hour = p.GetHour(date),
                Minute = p.GetMinute(date),
                Second = p.GetSecond(date),
                Millisecond = p.GetMilliseconds(date)
            };
        }

        public static DayOfWeek DayOfWeekend(PersianDate date)
        {
            PersianCalendar p = new PersianCalendar();
            var temp = ToGregorianDate(date);
            return p.GetDayOfWeek(temp);
        }

        public static string DayOfWeekString(PersianDate date)
        {

            DayOfWeek temp = DayOfWeekend(date);

            switch (temp)
            {
                case DayOfWeek.Saturday: return "شنبه";
                case DayOfWeek.Sunday: return "یکشنبه";
                case DayOfWeek.Monday: return "دوشنبه";
                case DayOfWeek.Tuesday: return "سه شنبه";
                case DayOfWeek.Wednesday: return "چهارشنبه";
                case DayOfWeek.Thursday: return "پنجشنبه";
                case DayOfWeek.Friday: return "جمعه";
            }

            return "";
        }
    }
}
