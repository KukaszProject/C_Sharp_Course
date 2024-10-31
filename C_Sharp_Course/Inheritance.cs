
    public class Inheritance
    {
        static void InheritanceMain(string[] args)
        {
            //-----------------------------------------------


            //Dog myDog = new Dog();
            //myDog.Eat();
            //myDog.MakeSound();

            //Cat cat = new Cat();
            //cat.MakeSound();


            //-----------------------------------------------

            //BaseClass baseClass = new BaseClass();
            //baseClass.ShowFields();

            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.AccessFields();
            //derivedClass.ShowFields();

            //-----------------------------------------------


            //Employee joe = new Employee("Joe", 24, "IT Tech", 1);
            //joe.DisplayEmployeeInfo();

            //Manager mark = new Manager("Mark", 18, "Project Manager", 123, 21);
            //mark.DisplayManagerInfo();

            //mark.BecomeOlder(5);
            //mark.DisplayPersonInfo();

            Exercise ex = new Exercise();
            ex.DemonstrateOverriding();

            Console.ReadKey();
        }
    }



    //----------------------------------------------------------
    class BaseClass
    {
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine($"Public {publicField}, Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
        }
    }


    //------------------------------------------------------//


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called.");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}");
        }

        /// <summary>Makes our object older!</summary>
        /// <param name="years"></param>
        /// <returns>Return new age</returns>
        public void BecomeOlder(int years)
        {
            Age += years;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }

        // Derived class constructor
        public Employee(string name, int age, string jobTitle, int employeeID) 
            : base(name, age) // Calling the base class constructor
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;

            Console.WriteLine("Employee constructor called.");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo(); // Call method from base class
            Console.WriteLine($"Job Title: {JobTitle}, employee Id: {EmployeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) 
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }


    //-----------------------------------------------


    public class Exercise
    {


        public void DemonstrateOverriding()
        {
            // TODO
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

        }

            public class Animal
            {
                public virtual void MakeSound()
                {
                    Console.WriteLine("Animal make sound.");
                }
            }
            public class Dog : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("Dog barks");
                }
            }

            public class Cat : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("Cat meows");
                }
            }
            
            
        }

//    class Animal
//    {
//        public void Eat()
//        {
//            Console.WriteLine("Eating...");
//        }

//        public virtual void MakeSound()
//        {

//            Console.WriteLine("Animal make sound...");
//        }
//    }

    

//    class Dog : Animal
//    {
//        public override void MakeSound()
//        {
//            base.MakeSound();
//            Console.WriteLine("Barking...");
//        }
//    }


//    class Cat : Animal
//    {
//        public override void MakeSound()
//        {
//            Console.WriteLine("Meowing...");
//        }
//    }

//    class Collie : Dog
//    {
//        public void GoingNuts()
//        {
//            Console.WriteLine("Collie going nuts...");
//        }
//    }

