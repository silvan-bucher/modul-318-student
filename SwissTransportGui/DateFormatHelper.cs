using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGui
{
    class DateFormatHelper
    {
        public DateTime convertDuration(String duration)
        {
            DateTime datetime = new DateTime();
            String days = duration.Substring(0, 2);
            String hours = duration.Substring(3, 2);
            String minutes = duration.Substring(6, 2);
            String seconds = duration.Substring(9, 2);
            //Console.WriteLine(duration);
            //Console.WriteLine(days);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);
            datetime = datetime.AddDays(Convert.ToDouble(days));
            datetime = datetime.AddHours(Convert.ToDouble(hours));
            datetime = datetime.AddMinutes(Convert.ToDouble(minutes));
            datetime = datetime.AddSeconds(Convert.ToDouble(seconds));
            //Console.WriteLine(datetime);
            return datetime;
        }

        public String convertIntToTimeString(int time)
        {
            if(time < 10)
            {
                return "0" + time.ToString();
            } else
            {
                return time.ToString();
            }
        }
    }
}
