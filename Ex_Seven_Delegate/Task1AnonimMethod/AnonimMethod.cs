namespace Ex_Seven_Delegate
{
    public delegate int MyDelegate(int x, int y, int z);
    public class MyDel
    {
        public MyDelegate anonimMethod = delegate (int x, int y, int z) { return (x + y + z) / 3; };
    }
}
