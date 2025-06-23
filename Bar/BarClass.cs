using FooBar.Lib;
using System;

namespace Bar
{
    public class BarClass
    {
        private Fake fake;
        public BarClass()
        {
            this.fake = new Fake();
        }

        public void DoSomething()
        {
            Console.WriteLine(this.fake.ToString());
        }

    }
}
