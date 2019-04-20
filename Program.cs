using System;

namespace Sample_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns");


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

            //Factory pattern
        }
    }
}
