using FooBar.Lib;
using System;

namespace Foo
{
    public class FooClass
    {
        private Fake fake;

        public FooClass()
        {
            this.fake = new Fake();
        }

        public void DoSomething()
        {
            Console.WriteLine(this.fake.ToString());
        }
    }
}
