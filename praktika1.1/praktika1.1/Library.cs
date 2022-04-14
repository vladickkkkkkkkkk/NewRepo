﻿using System;
using System.Collections.Generic;
using System.Text;

namespace praktika1._1
{
    class Library
    {
        private string Name { get; set; }
        private string Adress { get; set; }
        private int Date { get; set; }

        public Library()
        {
            Name = "";
            Adress = "";
            Date = 0;
        }
        public Library(string name, string adress, int date)
        {
            this.Name = name;
            this.Adress = adress;
            this.Date = date;
        }
        public void Print()
        {
            Console.Write($"Название: {Name}\n" +
                              $"Адрес: {Adress}\n" +
                              $"Год открытия: {Date}\n");
        }
        public void Input()
        {
            Console.Write("Введите название: ");
            this.Name = Console.ReadLine();
            Console.Write("Введите адрес: ");
            this.Adress = Console.ReadLine();
            Console.Write("Введите год открытия: ");
            this.Date = Convert.ToInt32(Console.ReadLine());
        }
    }
}
