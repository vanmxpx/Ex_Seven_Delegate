using NUnit.Framework;

namespace Ex_Seven_Delegate
{
    [TestFixture]
    class Test
    {
        [Test]
        public void Test1()
        {
            MyDel del = new MyDel();
            Assert.AreEqual(3, del.anonimMethod(3, 2, 4));
            Assert.AreNotEqual(3, del.anonimMethod(3, 6, 4));
        }

        [Test]
        public void Test2()
        {
            LOperators oper = new LOperators();

            Assert.AreEqual(6, oper.Add(2,4));
            Assert.AreEqual(3, oper.Sub(7, 4));
            Assert.AreEqual(12, oper.Mult(4, 3));
            Assert.AreEqual(2, oper.Div(6, 3));
            Assert.AreEqual(-1, oper.Div(2, 0));
        }

        [Test]
        [Repeat(10000)]
        public void Test3()
        {
            GroupDelegates group = new GroupDelegates();
            Assert.That(group.GetNumber(), Is.InRange(0, 1000));
        }

    }
}
