using ConsoleHostesAssistent;
using ConsoleHostessAssistant;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ConsoleHostessAssistant;

namespace ConsoleHostessAssistant
{
    public class Controller
    {
        public static void BeginningOfWork(bool flag) //(List<string> waiters, int id, bool flag)
        {
            //List<int> tablesList = new List<int>() { 1,3,4,6,7,8,11,13,28,27,21,22,25,26,30,31,35,36,37,38,40,41,42,43,50,51,52,53,54,56,57,58,59,60,61,62,70,71,72,73,74,75,76 };
            //List<string> waiters = ["Катя", "Маша", "Даша"]; // Задаем фиксированный список официантов 


            //var tablesList = new int[76]; // Задаем массив содержащий все номера столов в ресторане
            //for (int i = 0; i < tablesList.Length; i++)
            //{
            //    tablesList[i] = i;
            //}

            //var waitersHistory = new Dictionary<string, string>(); // Создаем словарь Dictionary<K, V>, где К это имя официанта, а V это строка содержащая номера столов через пробел
            //foreach (string element in waiters)
            //{
            //    waitersHistory.Add(element, "");
            //    Console.WriteLine(new string('=', 20));
            //    Console.WriteLine(element);
            //    Console.WriteLine(new string('=', 20));
            //}
             // Список id официантов готовых взять дополнительный стол

            int id = 0;

            //var tableStatus = new Dictionary<int, bool>(); // Создаем словарь Dictionary<K, V>, где К это стол, а V это статус стола (True / False)
            //foreach (var table in tablesList)
            //{
            //    tableStatus.Add(table, true);
            //}
            var Model = new  Model();
            var View = new View();

            Model.FillingTheTablesList();
            View.ShowWaiters();
            View.ConsoleMessage($"В зале имеется {Model.TableList.Count()+1} столов ");
            while (flag)
            {
                View.ShowMenu();
                int choice = View.RequestConsole("Введите номер выбранного пункта меню: ");// Ввод  c консоли пункта меню
                
                switch (choice)
                {
                    case 1:
                        int newTable = View.RequestConsole("Введите номер нового стола");
                        if (Model.TableList.Count()>newTable && Model.TableList[newTable].TableStatus == true)
                        {
                            id = Model.NewTable(id, newTable, Model.additionalTables);
                            Model.TableList[newTable].ChangeTableStatus(false);
                        }
                        else
                        {
                            View.ConsoleMessage("Некорректный номер стола, стол занят или стола с таким номером нет в зале");
                        }

                        break;
                    case 2:
                        int idForAdditionalTable = View.RequestConsole("Введите id официантов, которые готовы взять дополнительный стол");
                        if (Model.waiters.Count() > idForAdditionalTable)
                        {
                            Model.additionalTables.Add(idForAdditionalTable);
                            View.ConsoleMessage($"Следущий стол получит официант с id {idForAdditionalTable} ");
                        }
                        
                        else
                        {
                            View.ConsoleMessage("Официанта с таким id нет");
                        }
                        break;
                    case 3:
                        View.LastTable(Model);
                        break;
                    case 4:
                        View.History(Model);
                        // Вывод истории
                        break;
                    case 5:
                        View.ShowFreeTable(Model.TableList);
                        break;
                    case 6:
                        int numberTable = View.RequestConsole("Введите номер стола, статус которого нужно изменить");
                        Model.TableList[numberTable].ChangeTableStatus(true);
                        View.ConsoleMessage($"Статус стола изменен");
                        break;
                    case 7:
                        flag = false;
                        View.ConsoleMessage("Завершение работы");

                        break;
                    default:
                        Debug.WriteLine("Invalid option");
                        break;
                }

            }
        }
    }
}
