﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4_1
{

    enum Color
    {
        Red,
        White,
        Blue,
        Green,
        Black
    }

    class Auto
    {
        public string Marka { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public Color ColorCar {set; get;}
    }

    class Human
    {
        public string Name { set; get; }
        public string Model { set; get; }
        public string Number { set; get; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var humans = new List<Human>
            {
                new Human {Name = "Ivanov Ivan", Model = "Opel", Number = "123" },
                new Human {Name = "Petrov Petya", Model = "Mercedes", Number = "456" },
                new Human {Name = "Alexeev Alexey", Model = "Subaru", Number = "789" }
            };


            var cars = new List<Auto>
            {
                new Auto {Marka = "Opel", Model = "Adam", Year = 1999, ColorCar = Color.Black },
                new Auto {Marka = "Mercedes", Model = "Vito", Year = 2009, ColorCar = Color.Green },
                new Auto {Marka = "Subaru", Model = "Forester", Year = 2004, ColorCar = Color.White },

            };


            var query = from 

        }
    }
}
