using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Study_Lambda
{
    class Hi
    {
        protected string Name;
        public Hi(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Hi()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{this.Name}.BaseMethod()");
        }
    }

    class Derived:Hi
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class Study_Lambda
    {
        static void Main(string[] args)
        {
            Hi a = new Hi("A");
            a.BaseMethod();

            Derived b=new Derived("B");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
