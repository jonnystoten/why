using System;

namespace Why
{
    public class WhyCombinator
    {
        private static Func<TArg, TResult> Y<TArg, TResult>(Func<Func<TArg, TResult>, Func<TArg, TResult>> le)
        {
            return A<TArg, TResult>(f => B(le, f));
        }

        private static Func<TArg, TResult> A<TArg, TResult>(Func<dynamic, Func<TArg, TResult>> f)
        {
            return f(f);
        }

        private static Func<TArg, TResult> B<TArg, TResult>(Func<Func<TArg, TResult>, Func<TArg, TResult>> le, Func<dynamic, Func<TArg, TResult>> f)
        {
            return le(x => C(f, x));
        }

        private static TResult C<TArg, TResult>(Func<dynamic, Func<TArg, TResult>> f, TArg x)
        {
            return A(f)(x);
        }

        public int FactorialUsingY(int x)
        {
            var factorial = Y<int, int>(fac => n => n <= 2 ? n : n * fac(n - 1));
            return factorial(x);
        }
    }
}
