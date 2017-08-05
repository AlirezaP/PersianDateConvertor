# PersianDateConvertor
PerstianDateConvertor Is a Standard Library For Converting Between GregorianDate And PersianDate.
This Projects Type Is .NetStandardLibrary.
Compatible With .netframework or xamarin or .netcore ....<br/>


            var persianDate = PerstianDateConvertor.Convertor.ToPersianDate(DateTime.Now);
            Console.WriteLine(persianDate);
            
            var dayOfWeek = persianDate.DayOfWeek;
            Console.WriteLine(dayOfWeek);

            var dayOfWeekString = persianDate.DayOfWeekString;
            Console.WriteLine(dayOfWeekString);

            var gregorianDate = PerstianDateConvertor.Convertor.ToGregorianDate(persianDate);
            Console.WriteLine(gregorianDate);
