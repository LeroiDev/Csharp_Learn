using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSection_One
{
    internal class HotelBooking
    {
        public string GuestName;
        public DateTime StartDate;
        public DateTime EndDate;

        public HotelBooking(string sGuestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = sGuestName;
            StartDate = startDate;
            EndDate = startDate.AddDays(lengthOfStayInDays);
        }
    }
}




//The constructor of this class should take the following parameters (please maintain the given order and names):

//guestName(string)

//startDate(DateTime)

//lengthOfStayInDays(int)

//The constructor should set all fields of this class.

//The EndDate should be calculated in the constructor as the StartDate plus the lengthOfStayInDays .
//You can use the AddDays method from the DateTime type to calculate it. You can do it right in the constructor body.

