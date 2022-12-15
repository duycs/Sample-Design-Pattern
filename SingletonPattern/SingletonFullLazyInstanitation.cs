using System;

namespace SampleDesignPattern.SingletonPattern
{
    public sealed class SingletonFullLazyInstanitation
    {
        private SingletonFullLazyInstanitation(){}
        private static SingletonFullLazyInstanitation instance= null;
        public static SingletonFullLazyInstanitation Instance {
            get{
                if(instance == null){
                    instance = new SingletonFullLazyInstanitation();
                }
                return instance;
            }
        }

        //other public method
        public void ShowInstance(){
            if(instance==null)
                Console.WriteLine("instance not found");
            else 
                Console.WriteLine("instance found");
        }
       
    }
}