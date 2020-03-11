using System;
using System.Collections.Generic;
using Sample_Design_Pattern.AbstractFactoryPattern;
using Sample_Design_Pattern.FactoryMethodPattern;
using Sample_Design_Pattern.SingletonPattern;
using System.Linq;
using Sample_Design_Pattern.FacadePattern;
using Sample_Design_Pattern.ObserverPattern;
using Sample_Design_Pattern.ObserverPattern.BookingObserverPattern;
using System.Reflection;
using reflection;

namespace Sample_Design_Pattern
{

    public class DesignPattern {
        public string SINGLETON = "singleton";
        public string FACTORY_METHOD = "factory method";
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Design Patterns");
            string desinPatternName = Console.ReadLine();
            switch(desinPatternName.ToLower()){

                //CREATETIONAL PATTERN
                //Singleton pattern, Factory method pattern, Abstract factory pattern
                case "singleton":
                //Singleton pattern
                    Console.WriteLine("*** Singleton pattern ***");
                    SingletonFullLazyInstanitation.Instance.ShowInstance();
                    Console.WriteLine("*** End Singleton pattern ***");
                    break;

                case "factory method":
                    //Factory pattern
                    Console.WriteLine("*** Factory pattern ***");
                    Console.WriteLine("what Product do you want to known?");

                    string product = Console.ReadLine();
                    ProductFactory factory = null;
                    switch(product.ToLower()){
                        case "android":
                            factory = new AndroidFactory(1, "samsung anroid phone", 1000);
                            break;

                        case "ios":
                            factory = new IosFactory(2, "iphone", 500);
                            break;

                        default:
                            Console.WriteLine("not match any product");
                            return;
                    }
                    var productDetails = factory.GetProductDetails();
                    Console.WriteLine($"id: {productDetails.Id}\n name: {productDetails.Name}\n category: {productDetails.Category}\n quantity: {productDetails.Quantity}");
                    Console.WriteLine("*** End Factory pattern ***");
                    break;

                case "abstract factory":
                    Console.WriteLine("*** Abstract Factory pattern ***");
                    ContinentFactory africa = new AfricaFactory();
                    var animalWorld = new AnimalWorld(africa);
                    animalWorld.RunFoodChain();

                    ContinentFactory america = new AmericaFactory();
                    animalWorld = new AnimalWorld(america);
                    animalWorld.RunFoodChain();
                    Console.WriteLine("*** End Abstract Factory pattern ***");
                    break;

                //STRUCTOR PATTERN
                //Adapter pattern, Facade pattern
                case "adapter":
                 //Adapter pattern
                    Console.WriteLine("*** Adapter pattern ***");
                    string pageName = "Offer Page";
                    ITarget pageAdapter = new PageAdapter();

                    //show all page
                    var pages = pageAdapter.GetPages();
                    foreach(var page in pages){
                        Console.WriteLine(page);
                    }
                    //check pageName exist or not
                    if(pageAdapter.IsPageExist(pageName))
                        Console.WriteLine($"page {pageName} exist");
                    else
                        Console.WriteLine($"page {pageName} not exist");

                    Console.WriteLine("*** End Adapter pattern ***");
                break;
                
                case "facade":
                    Console.WriteLine("*** Facade pattern ***");
                    BookingFacade bookingFacede = new BookingFacade();
                    FacadePattern.Customer customer = new FacadePattern.Customer(1, "Alice");
                    bool isCanbook = bookingFacede.IsCanBook(customer, "Alexa", "12:00:00");
                    string message = isCanbook == true?$"{customer.Name} can book":$"{customer.Name} can't book";
                    Console.WriteLine(message);
                    Console.WriteLine("*** End Facade pattern ***");
                    break;

                //BEHAVIORAL PATTERN
                //Observer pattern
                case "observer":
                Console.WriteLine("*** Observer pattern ***");
                    // ConcreteSubject subject = new ConcreteSubject();
                    // subject.Attach(new ConcreteObserver(subject, "subjectA"));
                    // subject.Attach(new ConcreteObserver(subject, "subjectB"));
                    // subject.Attach(new ConcreteObserver(subject, "subjectC"));

                    // subject.SubjectStatate = "new state";
                    // subject.Notify();

                    string time10 = "10:00:00";
                    Booking bookingAt10 = new Booking(time10);
                    bookingAt10.Attach(new ObserverPattern.BookingObserverPattern.Customer(bookingAt10));
                    bookingAt10.Attach(new ObserverPattern.BookingObserverPattern.Customer(bookingAt10));

                    string time11 = "11:00:00";
                    Booking bookingAt11 = new Booking(time11);
                    bookingAt11.Attach(new ObserverPattern.BookingObserverPattern.Customer(bookingAt11));
                    bookingAt11.Attach(new ObserverPattern.BookingObserverPattern.Customer(bookingAt11));
                    bookingAt11.Attach(new ObserverPattern.BookingObserverPattern.Customer(bookingAt11));

                    Console.WriteLine("*** End Observer pattern ***");
                    break;

                case "reflection":
                    Console.WriteLine("***Reflection***");

                    Console.WriteLine("1. Assembly reflection:");
                    Assembly ass = Assembly.GetExecutingAssembly();
                    Type[] mTypes = ass.GetTypes();
                    Array.ForEach(mTypes, type => Console.WriteLine(type.Name));
                    //---
                    Console.WriteLine("2. Type Reflection:");
                    Type myClassType = new MyClass().GetType();
                    MemberInfo[] members = myClassType.GetMembers();
                    Array.ForEach(members, member => {
                        Console.WriteLine(string.Format("{0}:{1}", member.MemberType.ToString(), member));
                    });
                    //---
                    Console.WriteLine("3. Activator reflection:");
                    // TODO: Constructor on type 'reflection.MyClass+InnerClass' not found
                    Type innerClassType = Type.GetType("reflection.MyClass+InnerClass");
                    object obj1 = Activator.CreateInstance(innerClassType);
                    object obj2 = Activator.CreateInstance(innerClassType, "Duy");
                    innerClassType.InvokeMember("Hello", BindingFlags.InvokeMethod, null, obj1, null);
                    innerClassType.InvokeMember("Hello", BindingFlags.InvokeMethod, null, obj2, null);

                    Console.WriteLine("***End Reflection***");
                    break;

                default:
                Console.WriteLine("not match any pattern");
                break;
            }
        }
    }
}
