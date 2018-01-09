using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHierarchy
{
    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Bark()
        {
            throw new NotImplementedException();
        }
    }

    class Try
    {
        public static void foo()
        {
            IAnimal animal = new Dog();
        }

        void MoveAnimal(IAnimal animal)
        {
            animal.Move();
        }
    }
}
