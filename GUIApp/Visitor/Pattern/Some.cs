using System;

namespace GUIApp.Visitor
{
    public class Some<T> : IOption<T>
    {
        private readonly T _value;
        
        public Some(T value)
        {
            _value = value;
        }
        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onSome(_value);
        }
        public void Visit(Action onNone, Action<T> onSome)
        {
            onSome(_value);
        }
    }
}