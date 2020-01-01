using System;
using System.Collections.Generic;

namespace LifoStackExercise
{
    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot add empty values");
            }
            else
            {
                _list.Add(obj);
            }
        }

        public object Pop()
        {
            object removedItem;

            if (_list.Count > 0)
            {
                removedItem = _list[_list.Count - 1];
                _list.RemoveAt(_list.Count - 1);
            }
            else
            {
                throw new InvalidOperationException("List is empty");
            }
            return removedItem;
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
