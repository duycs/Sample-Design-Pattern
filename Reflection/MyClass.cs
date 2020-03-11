using System;

namespace reflection{
    public class MyClass {
        public class InnerClass {
            public void Hello(){
                Console.WriteLine("Hello");
            }

            public void HelloYou(string name){
                Console.WriteLine("Hello " + name);
            }
        }

    }
}