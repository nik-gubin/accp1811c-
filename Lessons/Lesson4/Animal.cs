using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //абстрактный класс
    abstract class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        //public virtual string Say()
        //{
        //    return "Кто же знает";
        //}

        //абстрактный метод
        //метод общий для классов наследников
        //но в данном классе не знаем его реализацию
        //реализация известна в наследниках
        public abstract string Say();


        public override string ToString()
        {
            return $"{name} издает '{Say()}'";
        }
    }
}
