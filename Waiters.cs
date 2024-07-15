using System.Collections.Generic;

namespace ConsoleHostessAssistant
{
    public class Waiters
    {
        public int WaiterId { get; set; }
        public string WaiterName { get; set; }
        //public List<int> HistoryOfWaiterTables { get; set; }
        public List<HistoryElement> HistoryOfWaiterTables { get; set; } = new List<HistoryElement>();
        //public List<HistoryElement> HistoryElements { get; set; }

        public bool Status = true;
        public override string ToString()
        {
            return WaiterName;
        }
        public Waiters(int waiterId, string waiterName)
        {
            WaiterId = waiterId;
            WaiterName = waiterName;
        }

        //public void AddTable(int tableId)
        //{
        //    HistoryOfWaiterTables.Add(tableId);         
        //}

        public void AddTable(int tableId, bool isAdditional = false)
        {

            HistoryOfWaiterTables.Add(new HistoryElement(tableId, isAdditional));

        }

        public void ChangeStatus()
        {
            Status = !Status;
        }

    }
}
