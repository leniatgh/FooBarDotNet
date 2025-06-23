using Bar;
using Foo;

namespace FooBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foo = new FooClass();
            var bar = new BarClass();
            foo.DoSomething();
            bar.DoSomething();
        }
    }
}
