using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleHostessAssistant
{
    public class Model
    {
        public List<int> additionalTables = new List<int>();// Список для хранения id официантов которые готовы взять дополнительные столы
        public List<Tables> TableList = new List<Tables>();// Список столов

        public void FillingTheTablesList(int NumberOfTables = 76)// Заполнение списка столов
        {
            for (int i = 0; i < NumberOfTables - 1; i++)
            {
                TableList.Add(new Tables(i, true));
            }
        }


        

        public List<Waiters> waiters = [new Waiters(0, "Kate"), new Waiters(1, "Masha"), new Waiters(2, "Dasha")]; // Список официантов


        //public static List<Waiters> waiterHistories = new List<Waiters>();
        public int NewTable(int id, int newTable, List< int>additionalTables) // Добавление нового стола 
        {

            if (additionalTables.Count() == 0)
            {
                Console.WriteLine(new string('=', 40));
                Debug.WriteLine("debug");
                Console.WriteLine($"Официант {waiters[id]} получил  новый стол {newTable}");
                Console.WriteLine(new string('=', 40));
                waiters[id].AddTable(newTable);
                int newID = idTest(id);
                return newID;

            }
            else
            {

                Console.WriteLine(new string('=', 40));
                Console.WriteLine($"Официант {waiters[additionalTables[0]]} получил новый стол {newTable} !дополнительно!");
                Console.WriteLine(new string('=', 40));
                waiters[additionalTables[0]].AddTable(newTable,true);
                additionalTables.RemoveAt(0);
                return id;
                //if (id == 0) { return id; }
                //else
                //{
                //    return (idTest(id) - 1);
                //}



            }
        }
        private int idTest(int id) // Проверка id: если id равно длинне списка присваиваем значения 0 иначе возвращается id + 1
        {
            if (id == waiters.Count - 1)
            {
                id = 0;
                return id;
            }
            else
            {
                return id + 1; 
            }
        }

        //void AddNewTable(string name, int newTable, IDictionary history) // Добавление новго стола в историю обслуживания определенногму официанту
        //{
        //    history[name] = history[name] + $"{newTable}, ";
        //    waiterHistories.Add(new Waiters(id, name));
        //    foreach (var waiter in waiterHistories)
        //    {
        //        waiter.ShowHistory();
        //    }
        //}



        //public static void TableStatus(Dictionary<int, bool> tableStatus, int newTable, bool status) // Присваивание значения true для всободных столов и false для занятых 
        //{
        //    if (status == false)
        //    {
        //        tableStatus[newTable] = false;
        //    }
        //    else
        //    {
        //        tableStatus[newTable] = true;

        //    }
        //}

    }
}

