using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class DateModifier
    {
        public void DifferenceDate(string date1String, string date2String)
        {
            DateTime date1 = DateTime.ParseExact(date1String, "yyyy M d", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(date2String, "yyyy M d", CultureInfo.InvariantCulture);
            var difference = date1 - date2;
            Console.WriteLine(Math.Abs(difference.Days));
        }
    }
}
