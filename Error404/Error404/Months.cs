using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Error404
{
    public class Months
    {
        public int MonthCon(string monthName)
        {
            DateTimeFormatInfo formatInfo = new DateTimeFormatInfo();
            DateTime date = DateTime.ParseExact(monthName, "MMMM", CultureInfo.CurrentCulture);
            
            return date.Month;
        }
    }
}
