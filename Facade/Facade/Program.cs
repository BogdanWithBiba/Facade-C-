
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Клас SubSystemA
    class SubSystemA
    {
        public void A1()
        {
            Console.WriteLine("SubSystemA метод A1 викликано.");
        }

        public void SubSystemAMethod()
        {
            Console.WriteLine("SubSystemA метод SubSystemAMethod викликано.");
        }
    }

    // Клас SubSystemB
    class SubSystemB
    {
        public void SubSystemBMethod()
        {
            Console.WriteLine("SubSystemB метод SubSystemBMethod викликано.");
        }

        public void B1()
        {
            Console.WriteLine("SubSystemB метод B1 викликано.");
        }
    }

    // Клас SubSystemC
    class SubSystemC
    {
        public void SubSystemCMethod()
        {
            Console.WriteLine("SubSystemC метод SubSystemCMethod викликано.");
        }

        public void C1()
        {
            Console.WriteLine("SubSystemC метод C1 викликано.");
        }
    }

    // Клас Facade
    class Facade
    {
        private SubSystemA _subsystemA;
        private SubSystemB _subsystemB;
        private SubSystemC _subsystemC;

        public Facade()
        {
            _subsystemA = new SubSystemA();
            _subsystemB = new SubSystemB();
            _subsystemC = new SubSystemC();
        }

        public void Operation1()
        {
            Console.WriteLine("\n Операція №1 --------------- ");
            _subsystemA.SubSystemAMethod();
            _subsystemB.SubSystemBMethod();
        }

        public void Operation2()
        {
            Console.WriteLine("\n Операція №2 --------------- ");
            _subsystemB.B1();
            _subsystemC.C1();
        }

        public void Operation3()
        {
            Console.WriteLine("\n Операція №3 --------------- ");
            _subsystemA.A1();
            _subsystemC.SubSystemCMethod();
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Operation1();
            facade.Operation2();
            facade.Operation3();

            Console.ReadKey();
        }
    }
}
