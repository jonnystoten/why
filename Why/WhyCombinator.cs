using System;

namespace Why
{
    public class WhyCombinator
    {
        private static dynamic Y(Func<Func<dynamic, dynamic>, Func<dynamic, dynamic>> le)
        {
            Func<Func<dynamic, dynamic>, dynamic> func = f => f(f);
            return func(f => le(x => f(f)(x)));
        }

        public int FactorialUsingY(int x)
        {
            var factorial = Y(fac => n => n <= 2 ? n : n * fac(n - 1));
            return factorial(x);
        }
    }
}
