using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleHostessAssistant
{
    public class HistoryElement // Первичный конструктор 
    {
        public int TableId { get; set; }
        public bool IsAdditional { get; set; }
        public HistoryElement(int TableId, bool isAdt)
        {
            this.TableId = TableId;
            this.IsAdditional = isAdt;
        }
        public override string ToString()
        {
            if (this.IsAdditional)
            {
                return $"{TableId}(Additional)";
            }
            else
            {
                return TableId.ToString();
            }
        }
    }
}
