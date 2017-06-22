using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GUIApp.Visitor;

namespace GUIApp.Iterator
{
    public class OptionList<T> : IOptionIterator<T>
    {
        private OptionList<T> _next;
        private OptionList<T> _current;
        private T _value;
        private bool _hasNext;
        private bool _isEmpty;
        
        public OptionList()
        {
            _hasNext = false;
            _isEmpty = true;
            _current = this;
        }

        private OptionList(T value)
        {
            _value = value;
        }

        public IOption<T> GetNext()
        {
            var current = _current;
            _current = current._next;
            
            if(current._isEmpty)
                return new None<T>();
            
            return new Some<T>(_value);
        }

        public void Add(T value)
        {
            var entry = this;
            while (entry._hasNext)
                entry = _next;

            if (entry._isEmpty)
            {
                entry._value = value;
                entry._isEmpty = false;
            }
            else
            {
                entry._next = new OptionList<T>(value);
                entry._hasNext = true;
            }
        }

        public IEnumerator<IOption<T>> GetEnumerator()
        {
            var current = this;
            
            while (current._hasNext)
            {
                if (current._isEmpty)
                {
                    yield return new None<T>();
                }
                
                yield return new Some<T>(current._value);
                current = current._next;
            }
            
            if(current._isEmpty)
                yield return new None<T>();
            else
                yield return new Some<T>(current._value);
            
            _current = this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}