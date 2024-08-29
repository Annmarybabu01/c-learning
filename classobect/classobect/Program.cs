using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobect
{
    internal class Program
    {   
        //method overriding
        class PolymorphismBase
        {
            public virtual void Display()
            {
                Console.WriteLine("I am base class");
            }
        }
        class Polymorphismderived : PolymorphismBase
        {
            public override void Display()
            {
                Console.WriteLine("I am derived class");
            }
        }
        //abraction and method overiding
        abstract class AbstractBase
        {
            public abstract void Name();
            public void NameAccepted()
            {
                Console.WriteLine("name accepted");
            }

        }
        class AbstractDerivedClass: AbstractBase
        {
            public override void Name()
            {
                Console.WriteLine("my name is ann");
            }
        }

        //inheritance
        class BaseClass
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }
        class DerivedClasss : BaseClass
        {
            public void Mul(int a)
            {
                int b = a * 6;
                Console.WriteLine("derived class answer "+b);
            }
        }
        static void Main(string[] args)
        {
            //DerivedClasss obj = new DerivedClasss();
            //int n=obj.Add(2,4);
            //obj.Mul(n);
            //AbstractDerivedClass nameObj=new AbstractDerivedClass();
            //nameObj.Name();
            //nameObj.NameAccepted();
            PolymorphismBase displayObj=new Polymorphismderived();
            displayObj.Display();
        }
    }
}
