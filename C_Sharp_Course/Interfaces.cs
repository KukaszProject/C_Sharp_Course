
    //public class Animal
    //{
    //    public virtual void MakeSound()
    //    {
    //        Console.WriteLine("Some generic animal sound");
    //    }
    //}

    //public class Dog : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Bark");
    //    }
    //}

    //public class Cat : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Meow");
    //    }
    //}




    //public interface IAnimal
    //{
    //    void MakeSound();
    //    void Eat(string food);
    //}

    //public class Dog : IAnimal
    //{
    //    public void Eat(string food)
    //    {
    //        Console.WriteLine("Dog ate " + food);
    //    }

    //    public void MakeSound()
    //    {
    //        Console.WriteLine("Bark");
    //    }
    //}

    //public class Cat : IAnimal
    //{
    //    public void Eat(string food)
    //    {
    //        Console.WriteLine("Cat ate " + food);
    //    }

    //    public void MakeSound()
    //    {
    //        Console.WriteLine("Meow");
    //    }
    //}


    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of: {amount}");
            //Processing logic...
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of: {amount}");
            //Processing logic...
        }
    }

    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    

    public class Interfaces
    {
        public static void InterfaceMain()
        {
            //Dog dog = new Dog();
            //dog.MakeSound();
            //dog.Eat("Treat");

            //Cat cat = new Cat();
            //cat.Eat("fish");
            //cat.MakeSound();

            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor payPalProcessor = new PayPalProcessor();
            paymentService = new PaymentService(payPalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

            Console.ReadKey();
        }
    }
