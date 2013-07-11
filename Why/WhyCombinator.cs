using System;

namespace Why
{
    public class WhyCombinator
    {
        private static Func<T, T> Y<T>(Func<Func<T, T>, Func<T, T>> le)
        {
            return A<T>(f => B(le, f));
        }

        private static Func<T, T> A<T>(Func<dynamic, Func<T, T>> f)
        {
            return f(f);
        }

        private static Func<T, T> B<T>(Func<Func<T, T>, Func<T, T>> le, Func<dynamic, Func<T, T>> f)
        {
            return le(x => C(f, x));
        }

        private static T C<T>(Func<dynamic, Func<T, T>> f, T x)
        {
            return A(f)(x);
        }

        public int FactorialUsingY(int x)
        {
            var factorial = Y<int>(fac => n => n <= 2 ? n : n * fac(n - 1));
            return factorial(x);
        }
    }
}
