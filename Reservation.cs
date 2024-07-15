using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHostessAssistant
{
    public class Reservation
    {
        DateTime DateTime { get; set; }
        int ReservationTableNumder { get; set; }
        string ReservationName { get; set; }
        string ReservationPhoneNumder { get; set; }
        string Deescription { get; set; }

        Reservation(DateTime dateTime, int reservationTableNumder, string reservationName, string reservationPhoneNumder, string deescription)
        {
            DateTime = dateTime;
            ReservationTableNumder = reservationTableNumder;
            ReservationName = reservationName;
            ReservationPhoneNumder = reservationPhoneNumder;
            Deescription = deescription;
        }
    }
}
