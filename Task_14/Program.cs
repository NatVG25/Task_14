using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("кошка"); //создаем экземпляр класса Cat
            Dog dog = new Dog("собака"); //создаем экземпляр класса Dog
            cat.ShowInfo(); //вызываем метод ShowInfo для класса Cat
            dog.ShowInfo(); //вызываем метод ShowInfo для класса Dog
            Console.ReadKey();

        }
    }

    abstract class Animal //создаем абстрактный класс Animal
    {
        public abstract string Name { get; set; } //создаем абстрактное свойство - название животного
        public abstract void Say(); //абстрактный метод Say, который выводит звук, который издает животное
        public Animal() //конструктор, устанавливающий значение по умолчанию для названия;
        {
            
        }

        public void ShowInfo() //неабстрактный метод, который выводит на консоль последовательно название, а затем звук (вызывая метод Say).
        {
            Console.WriteLine("Я {0}", Name);
            Say();
        }
        
    }
    class Cat : Animal //создаем класс Cat
    {
        string name; //закрытое поле в которое присваивается значение
        public Cat(string name) //конструктор с параметром имя
        
        {
            Name = name;
        }

        public override string Name //переопределяем свойство имя
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say() //переопределение метода Say для кошки
        {
            Console.WriteLine("Мяу!");
        }
       

}
    class Dog : Animal
    {
        public string name; //закрытое поле в которое присваивается значение
        public Dog(string name) //конструктор с параметром имя
        {
            Name = name;
        }
        public override string Name //переопределяем свойство имя
        {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
        }
        public override void Say() //переопределение метода Say для собаки
        {
                Console.WriteLine("Гав!");
        }
       
    }
}
