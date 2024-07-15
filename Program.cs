using ConsoleHostessAssistant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleHostesAssistent
{


    internal class Program
    {
        static void Main(string[] args)
        {



            //Console.WriteLine("Введите список официантов через пробел");
            //string waiters = Convert.ToString(Console.ReadLine());
            //string[] waitersList = waiters.Split(' ');
            //List<string> queueWaiters = new List<string>();

            //foreach (var word in waitersList)
            //{
            //    queueWaiters.Add(Convert.ToString(word));
            //}


            // Вызов метода из Сontroller для начала роботы с флагом true

            Controller.BeginningOfWork(true);//     Пpедыдущий вариант :(queueWaiters, 0,true);
            Console.ReadKey();


        }
    }
    //public class View
    //{

    //    // Работа с консолью
    //    public static void Menu() // Вывод меню 
    //    {

    //        Console.WriteLine("Menu:" + "\n" +
    //            "1. Добавить новый стол" + "\n" +
    //            "2. Добавить дополнительный стол официанту по id" + "\n" +
    //            "3. Получить последние столы официантов  " + "\n" +
    //            "4. Получить историю обслуживания" + "\n" +
    //            "5. Узнать свободные столы" + "\n" +
    //            "6. Изменить статус стола на свободный" + "\n" +
    //            "7. Завершение рабочего дня " + "\n"
    //            );




    //    }
    //    //Dictionary<int, List<int>> waitersHistory
    //    public static void History(Dictionary<string, string> waitersHistory) // Вывод истории в формате "Waiter = {name}, tablesHistory = {tables}
    //    {
    //        foreach (KeyValuePair<string, string> element in waitersHistory)
    //        {

    //            Console.WriteLine("Waiter = {0}, tablesHistory = {1}", element.Key, element.Value);
    //        }
    //    }

    //    public static void LastTable(Dictionary<string, string> waitersHistory) // Вывод последних обслуживаемых столов всех официантов по списку 
    //    {
    //        foreach (KeyValuePair<string, string> kvp in waitersHistory)
    //        {
    //            string list = kvp.Value;
    //            string[] tables = list.Split(",");
    //            Console.WriteLine("Waiter = {0}, last table = {1}", kvp.Key, tables[tables.Length - 2]);
    //        }
    //    }
    //    public static void ShowFreeTable(Dictionary<int, bool> tableStatus) // Вывод своболных столов с статусом True 
    //    {
    //        Console.WriteLine("Свободные столы :");
    //        foreach (KeyValuePair<int, bool> table in tableStatus)
    //        {
    //            if (table.Value == true && table.Key != 0)
    //            {
    //                Console.Write($"{table.Key},");
    //            }

    //        }

    //        Console.Write("\r\n");
    //    }

    //}


    //public class Controller {
    //    public static void BeginningOfWork(bool flag)//(List<string> waiters, int id, bool flag)
    //    {
    //        //List<int> tablesList = new List<int>() { 1,3,4,6,7,8,11,13,28,27,21,22,25,26,30,31,35,36,37,38,40,41,42,43,50,51,52,53,54,56,57,58,59,60,61,62,70,71,72,73,74,75,76 };
    //         List<string> waiters = ["Катя", "Маша", "Даша"]; // Задаем фиксированный список официантов 


    //        var tablesList = new int[76]; // Задаем массив содержащий все номера столов в ресторане
    //        for (int i = 0; i < tablesList.Length; i++)
    //        {
    //            tablesList[i] = i;
    //        }

    //        var waitersHistory = new Dictionary<string, string>(); // Создаем словарь Dictionary<K, V>, где К это имя официанта, а V это строка содержащая номера столов через пробел
    //        foreach (string element in waiters)
    //        {
    //            waitersHistory.Add(element, "");
    //            Console.WriteLine(new string('=', 20));
    //            Console.WriteLine(element);
    //            Console.WriteLine(new string('=', 20));
    //        }
    //        List<int> additionalTables = new List<int>(); // Список id официантов готовых взять дополнительный стол

    //        int tableId = 0;

    //        var tableStatus = new Dictionary<int, bool>(); // Создаем словарь Dictionary<K, V>, где К это стол, а V это статус стола (True / False)
    //        foreach (var table in tablesList)
    //        {
    //            tableStatus.Add(table, true);
    //        }


    //        while (flag)
    //        {
    //            View.Menu();
    //            int choice = Convert.ToInt32(Console.ReadLine());// Ввод  c консоли пункта меню

    //            switch (choice)
    //            {
    //                case 1:
    //                    Console.WriteLine($"Введите номер нового стола");
    //                    int newTable = Convert.ToInt32(Console.ReadLine());
    //                    tableId = Model.NewTable(waiters,tableId, newTable, additionalTables, waitersHistory);
    //                    Model.TableStatus(tableStatus, newTable, false);
    //                    break;
    //                case 2:
    //                    Console.WriteLine($"Введите id официантов, которые готовы взять дополнительный стол");
    //                    int additioinlTable = Convert.ToInt32(Console.ReadLine());
    //                    additionalTables.Add(additioinlTable);
    //                    break;
    //                case 3:

    //                    View.LastTable(waitersHistory);
    //                    break;
    //                case 4:
    //                    View.History(waitersHistory);
    //                    // Вывод истории
    //                    break;
    //                case 5:
    //                    View.ShowFreeTable(tableStatus);
    //                    break;
    //                case 6:
    //                    Console.WriteLine($"Введите номер стола, статус которого нужно изменить");
    //                    int numberTable = Convert.ToInt32(Console.ReadLine());
    //                    Model.TableStatus(tableStatus, numberTable, true);
    //                    break;
    //                case 7:
    //                    flag = false;
    //                    break;
    //                default:
    //                    Debug.WriteLine("Invalid option");
    //                    break;




    //            }
    //        }

    //while (id < waiters.Count)
    //{
    //    Console.WriteLine($"Введите номер нового стола");
    //    int newTable = Convert.ToInt32(Console.ReadLine());
    //    if (tablesList.Any(n => n == newTable))
    //    {
    //        Console.WriteLine($"Введите id официантов, которые готовы взять дополнительный стол или число 99, если желающих нет");
    //        string additioinlTablesAll = Console.ReadLine();
    //        string[] tables = additioinlTablesAll.Split(' ');
    //        List<int> additionalTables = new List<int>();
    //        Console.WriteLine($"Введите 1, если нужно показать историю обслуживания или 0 если история не нужна");
    //        int historyflag = Convert.ToInt32(Console.ReadLine());
    //        if (historyflag == 1)
    //        {
    //            foreach (KeyValuePair<string, string> kvp in waitersHistory)
    //            {
    //                Console.WriteLine("Waiter = {0}, tablesHistory = {1}", kvp.Key, kvp.Value);
    //            }
    //        }

    //        foreach (var word in tables)
    //        {
    //            additionalTables.Add(Convert.ToInt32(word));

    //        }

    //        if (newTable == 0)
    //        {
    //            break;
    //        }
    //        id = NewTable(waiters, id, newTable, additionalTables, waitersHistory);
    //        if (id == waiters.Count)
    //        {
    //            id = 0;
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Не верный номер стола, такого стола нет в зале");
    //    }
    //}

    //    } 
    //}

    //public class Model
    //{

    //    public static List<Waiters> waiterHistories = new List<Waiters>();
    //    public static int NewTable(List<string> waiters, int id, int newTable, List<int> additionalTables, IDictionary historyWeiters) // 
    //    {
    //        static int idTest(int id, List<string> weitersForTest) // Проверка id: если id равно длинне списка присваиваем значения 0 иначе возвращается id + 1
    //        {
    //            if (id == weitersForTest.Count - 1)
    //            {
    //                id = 0;
    //                return id;
    //            }
    //            else { return id + 1; }
    //        }

    //        if (additionalTables.Count() == 0)
    //        {
    //            Console.WriteLine("======================================================");
    //            //Console.WriteLine(waiters.Count());
    //            //Console.WriteLine(id);
    //            Debug.WriteLine("debug");
    //            Console.WriteLine($"Официант {waiters[id]} получил  новый стол {newTable}");
    //            Console.WriteLine("======================================================");
    //            int newID = idTest(id, waiters);
    //            AddNewTable(waiters[id], newTable, historyWeiters);
    //            return newID;

    //        }
    //        else
    //        {

    //            Console.WriteLine("======================================================================================");
    //            Console.WriteLine($"Официант {waiters[additionalTables[0]]} получил новый стол {newTable} !дополнительно!");
    //            Console.WriteLine("======================================================================================");
    //            AddNewTable(waiters[additionalTables[0]], newTable, historyWeiters);
    //            additionalTables.RemoveAt(0);
    //            return idTest(id, waiters);



    //        }

    //        void AddNewTable(string name, int newTable, IDictionary history) // Добавление новго стола в историю обслуживания определенногму официанту
    //        {
    //            history[name] = history[name] + $"{newTable}, ";
    //            waiterHistories.Add(new Waiters(id, name));
    //            foreach (var waiter in waiterHistories)
    //            {
    //                waiter.ShowHistory();
    //            }
    //        }


    //    }
    //    public static void TableStatus(Dictionary<int, bool> tableStatus, int newTable, bool status) // Присваивание значения true для всободных столов и false для занятых 
    //    {
    //        if (status == false)
    //        {
    //            tableStatus[newTable] = false;
    //        }
    //        else
    //        {
    //            tableStatus[newTable] = true;

    //        }
    //    }
    //}
}





        
    

            

          
        
    

