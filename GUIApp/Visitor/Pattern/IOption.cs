using System;

namespace GUIApp.Visitor
{
    public interface IOption<T>
    {
        U Visit<U>(Func<U> onNone, Func<T, U> onSome);
        void Visit(Action onNone, Action<T> onSome);
    }
}