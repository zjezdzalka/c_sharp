using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public sealed class asdba
{
    string nigger { get; set; }
}

namespace sipheros_los_pingwinos_test_2024_09_12
{
    public abstract class asd
    {
        public asd() { }
        public abstract void draw();
        public string a2sd;
        protected abstract void as12();
    }

    public abstract class nigger
    {
        public abstract void asd();
    }
    public class asdd : asd
    {
        // all of abstract properties in base must be included in the child that inherits values
        public override void draw()
        {
            Console.WriteLine("sdf");
        }
        
        protected override void as12() {
            Console.Write("3214");
        }

    }

    public class Pingwinos
    {
        protected class nigger3
        {
            string asd { get; set; }
        }
        private decimal balance;
        public virtual void Run()
        {
            // virtual and abstract can not be private
            Console.WriteLine("Nig");
        }
        public Pingwinos(string a)
        {
            Console.WriteLine($"created pingwinos {a}");
        }
        public Pingwinos()
        {
            Console.WriteLine("created pingwinos2");
        }
    }
    protected class nigger1
    {

    }
    class Sipheros : Pingwinos
    {

        public override void Run()
        {
            Console.WriteLine("asd");
        }
        public Sipheros() : base()
        {
            
            Console.WriteLine("Pingwin is named Sipheros");
        }
        
        public Sipheros(string a) : base(a)
        {
            //Doesnt work if constructor is private (overall you cant access private stuff from parent class
            //It does what is contained in the base constructor and then does what is in this one.
            //You can give parameters to the base constructor by adding it into the params of the inherited class and then adding them into base();
            Console.WriteLine("Pingwin is named Sipheros {0}",a);
        }
    }
    class Madagascaros : Pingwinos
    {
        public Madagascaros() : base()
        {
            //with a private constructor you cannot create an object
            Console.WriteLine("Created madagascar");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pingwinos b = new Pingwinos();
            Sipheros a = new Sipheros();
            Madagascaros c = new Madagascaros();

            Pingwinos b2 = new Pingwinos("asd");
            Sipheros a2 = new Sipheros("ger");
            b.Run();
            a.Run();
            c.Run();


            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            asd sdf = new asdd();
            sdf.draw();

            asdd dfg = new asdd();
            dfg.draw();

            //cant do as12 bc of protection level
            asdba A = new asdba();

            Pingwinos.nigger3 Niggwe = new Pingwinos.nigger3();
            Console.ReadKey();
        }
    }
}
