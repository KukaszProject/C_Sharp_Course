using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course
{
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }


    public class Builder : IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
        }

        public void SetHammer(Hammer hammer)
        {
           _hammer = hammer;

        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }



    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood!");
        }
    }

    //public class Builder
    //{



        //----------------------------------------------//
        //Builder is responsible for creating its dependencies
        //----------------------------------------------//

        //private Hammer _hammer;
        //private Saw _saw;

        //public Builder()
        //{
        //    _hammer = new Hammer(); 
        //    _saw = new Saw();
        //}



        //----------------------------------------------//
        // Constructor Dependency Injection (DI)
        //----------------------------------------------//

        //public Builder(Hammer hammer, Saw saw)
        //{
        //    _hammer = hammer;
        //    _saw = saw;
        //}
        //public void BuildHouse()
        //{
        //    _hammer.Use();
        //    _saw.Use();
        //    Console.WriteLine("House built.");
        //}


        //----------------------------------------------//
        // Setter Dependency Injection (DI)
        //----------------------------------------------//

        //public Hammer Hammer { get; set; }
        //public Saw Saw { get; set; }

        //public void BuildHouse()
        //{
        //    Hammer.Use();
        //    Saw.Use();
        //    Console.WriteLine("House built.");
        //}
    //}


    public class Dependencies
    {
        public static void DependenciesMain()
        {

            //----------------------------------------------//
            // Constructor Dependency Injection (DI)
            //----------------------------------------------//

            //Hammer hammer = new Hammer();
            //Saw saw = new Saw();
            //Builder builder = new Builder(hammer, saw);


            //----------------------------------------------//
            // Setter Dependency Injection (DI)
            //----------------------------------------------//

            //Hammer hammer = new Hammer(); // Create Dependencies Outside
            //Saw saw = new Saw();
            //Builder builder = new Builder();
            //builder.Hammer = hammer; // Inject Dependencies via Setter
            //builder.Saw = saw; // Inject Dependencies via Setter



            //----------------------------------------------//
            // Interface Dependency Injection (DI)
            //----------------------------------------------//
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.SetSaw(saw);
            builder.SetHammer(hammer);

            builder.BuildHouse();

            Console.ReadKey();
        }
    }
}
