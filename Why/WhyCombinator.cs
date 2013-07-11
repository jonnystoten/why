using System;

namespace Why
{
    public class WhyCombinator
    {
        private static dynamic Y(Func<Func<dynamic, dynamic>, Func<dynamic, dynamic>> le)
        {
            return A(f => B(le, f));
        }

        private static dynamic A(Func<dynamic, dynamic> f)
        {
            return f(f);
        }

        private static dynamic B(Func<Func<dynamic, dynamic>, Func<dynamic, dynamic>> le, Func<dynamic, dynamic> f)
        {
            return le(x => C(f, x));
        }

        private static dynamic C(Func<dynamic, dynamic> f, dynamic x)
        {
            return A(f)(x);
        }

        public int FactorialUsingY(int x)
        {
            var factorial = Y(fac => n => n <= 2 ? n : n * fac(n - 1));
            return factorial(x);
        }
    }
}
