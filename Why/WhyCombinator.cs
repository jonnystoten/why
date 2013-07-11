using System;

namespace Why
{
    public class WhyCombinator<TArg, TResult>
    {
        private readonly Func<TArg, TResult> actualFunc;

        public WhyCombinator(Func<Func<TArg, TResult>, Func<TArg, TResult>> le)
        {
            actualFunc = Y(le);
        }

        public TResult Execute(TArg arg)
        {
            return actualFunc(arg);
        }

        private static Func<TArg, TResult> Y(Func<Func<TArg, TResult>, Func<TArg, TResult>> le)
        {
            return PassFunctionToItself(f => le(x => GetAnswer(f, x)));
        }

        private static TResult GetAnswer(Func<dynamic, Func<TArg, TResult>> f, TArg x)
        {
            return PassFunctionToItself(f)(x);
        }

        private static Func<TArg, TResult> PassFunctionToItself(Func<dynamic, Func<TArg, TResult>> f)
        {
            return f(f);
        }
    }
}
