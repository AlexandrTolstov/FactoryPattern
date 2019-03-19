﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();
        }
        //Абстрактный класс строительной компании
        abstract class Developer
        {
            public string Name { get; set; }
            public Developer(string n)
            {
                Name = n;
            }
            //фабричный метод
            abstract public House Create();
        }
        abstract class House { }
        class PanelHouse : House
        {
            public PanelHouse()
            {
                Console.WriteLine("Панельный дом построен");
            }
        }
        class WoodHouse : House
        {
            public WoodHouse()
            {
                Console.WriteLine("Деревянный дом построен");
            }
        }
        //Строит панельные дома
        class PanelDeveloper : Developer
        {
            public PanelDeveloper(string n) : base(n) { }
            public override House Create()
            {
                return new PanelHouse();
            }
        }
        //Строит деревянные дома
        class WoodDeveloper : Developer
        {
            public WoodDeveloper(string n) : base(n) { }
            public override House Create()
            {
                return new WoodHouse();
            }
        }
    }
}
