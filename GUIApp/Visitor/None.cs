using System;

namespace ConsoleApplication1.Visitor
{
    public class None<T> : IOption<T>
    {
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onNone();
        }

        public void Visit(Action onNone, Action<T> onSome)
        {
            onNone();
        }
    }
}

