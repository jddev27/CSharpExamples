using System;

namespace MethodOverloadingEx
{
    class ParentCall
    {
        public void Call(int x)
        {
            Console.WriteLine("Parent.Call(int x)");
        }

        //Override Example -Uncomment to see it 

//        public  virtual void Call(int x)
//        {
//            Console.WriteLine("Parent.Call(int x)");
//        }
    }
}