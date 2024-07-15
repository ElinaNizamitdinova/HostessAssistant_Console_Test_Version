using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHostessAssistant
{
    public class View
    {
        
        
        public List<String> Menu = new List<string> { "Menu:","1. Добавить новый стол","2. Добавить дополнительный стол официанту по id","3. Получить последние столы официантов  " ,
                "4. Получить историю обслуживания",
                "5. Узнать свободные столы" ,
                "6. Изменить статус стола на свободный" ,
                "7. Завершение рабочего дня "};
        public void ShowMenu() // Вывод меню 
        {
            foreach (var item in Menu)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Menu:" + "\n" +
            //    "1. Добавить новый стол" + "\n" +
            //    "2. Добавить дополнительный стол официанту по id" + "\n" +
            //    "3. Получить последние столы официантов  " + "\n" +
            //    "4. Получить историю обслуживания" + "\n" +
            //    "5. Узнать свободные столы" + "\n" +
            //    "6. Изменить статус стола на свободный" + "\n" +
            //    "7. Завершение рабочего дня " + "
        }
        //Dictionary<int, List<int>> waitersHistory
        public void History(Model Model)//(Dictionary<string, string> waitersHistory) // Вывод истории в формате "Waiter = {name}, tablesHistory = {tables}
        {   //var Model = new Model();
            foreach ( Waiters waiter in Model.waiters)
            {

                string table = " ";
                
                foreach (var item in waiter.HistoryOfWaiterTables)
                    {
                        table = table + item.ToString() + ", ";
                    }
                    Console.WriteLine(waiter.WaiterName + ":" + table);
                
            }
        }
        //{
        //    foreach (KeyValuePair<string, string> element in waitersHistory)
        //    {

        //        Console.WriteLine("Waiter = {0}, tablesHistory = {1}", element.Key, element.Value);
        //    }
        //}

        public void LastTable(Model Model)
        {
            foreach (Waiters waiter in Model.waiters)
            {
                Console.WriteLine("Waiter: " + waiter.WaiterName + " " + waiter.HistoryOfWaiterTables.Last());
            }
        }//Dictionary<string, string> waitersHistory) // Вывод последних обслуживаемых столов всех официантов по списку 
        //{
        //    foreach (KeyValuePair<string, string> kvp in waitersHistory)
        //    {
        //        string list = kvp.Value;
        //        string[] tables = list.Split(",");
        //        Console.WriteLine("Waiter = {0}, last table = {1}", kvp.Key, tables[tables.Length - 2]);
        //    }
        //}
        public void ShowFreeTable(List<Tables> Tables) // Вывод своболных столов с статусом True 
        {
            Console.WriteLine("Свободные столы :");
            foreach (Tables table in Tables)
            {
                if (table.TableStatus == true && table.TableNumber!= 0)
                {
                    Console.Write($"{table.TableNumber},");
                }

            }

            Console.Write("\r\n");
        }
        public void ShowWaiters()
        {
            var Model = new Model();
            ConsoleMessage("Список официантов:");
            foreach (Waiters waiter in Model.waiters)
            {
                Console.WriteLine($"Официант с id {waiter.WaiterId} :{waiter.WaiterName}");            }
        }
        public int  RequestConsole(string Message)
        {
            try
            {
                Console.WriteLine(Message);
                int Answer = Convert.ToInt32(Console.ReadLine());
                return Answer;
            }
            catch (FormatException ex)
            {
                ConsoleMessage(ex.Message);
                return -1;
            }
            }
        public void ConsoleMessage(string Message)
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine(Message);
            Console.WriteLine(new string('=', 40));
        }
    }
}

