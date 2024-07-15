using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHostessAssistant
{
    public class Tables
    {
        public int TableNumber {  get; set; }
        public bool TableStatus { get; set; }
        public Reservation Reservation { get; set; }

        
        //public string TableReservation { get; set; }
        public Tables(int TableNumber, bool TableStatus, Reservation reserv = null)
        {
            this.TableNumber = TableNumber;
            this.TableStatus = TableStatus;
            this.Reservation = reserv;
        }
        public void ChangeTableStatus(bool NewStatus)
        {
            TableStatus =  NewStatus;
        }


    }
}
