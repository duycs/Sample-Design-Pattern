using System;
using Sample_Design_Pattern.FactoryMethodPattern;

namespace Sample_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns");
            string desinPatternName = Console.ReadLine();
            switch(desinPatternName){
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

                default:
                Console.WriteLine("not match any pattern");
                break;
            }
        }
    }
}
