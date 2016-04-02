using System;

namespace Ex_Seven_Delegate
{
    public partial class Presenter
    {
        public void Task3()
        {
            Console.Clear();

            GroupDelegates group = new GroupDelegates();
            Console.WriteLine("Geting numbers' average:");
            Console.WriteLine(group.GetNumber());

            Console.ReadKey();
        }
    }
}
