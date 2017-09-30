using System;

namespace MethodOverloadingEx
{
    class ChildCall : ParentCall
    {
        public void Call(double y)
        {
            Console.WriteLine("Child.Call(double y)");
        }

        //Inheritace override example
//        public override void Call(int y)
//        {
//            Console.WriteLine("Child.Call(double y)");
//        }
    }
}