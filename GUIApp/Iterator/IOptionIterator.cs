using System.Collections.Generic;
using GUIApp.Visitor;

namespace GUIApp.Iterator
{
    //!NOTE the only reason to implement the IEnumerable is to make the Iterator usable in a foreach loop
    public interface IOptionIterator<T> : IEnumerable<IOption<T>>
    {
        IOption<T> GetNext();
    }
}