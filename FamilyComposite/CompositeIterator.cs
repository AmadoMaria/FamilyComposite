using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace FamilyComposite
{
    public class CompositeIterator : IEnumerator
    {
        Stack stack = new Stack();

        public object Current => throw new NotImplementedException();

        public CompositeIterator(IEnumerator iterator) {
            stack.Push(iterator);
        }

        public Object Next() {
            if (HasNext()) {
                IEnumerator iterator = (IEnumerator) stack.Peek();
                FamilyComponent component = (FamilyComponent)iterator.MoveNext();
                if (component is FamilyAncestral) { 
                    stack.Push(component.CreateIterator());
                }
                return component;
            }
            else {
                return null;
            }
        }

        public bool HasNext(){
            if (stack.Count == 0) {
                return false;
            }
            else {
                IEnumerator iterator = (IEnumerator) stack.Peek();
                if (!iterator.MoveNext()) {
                    stack.Pop();
                    return HasNext();
                }
                else {
                    return true;
                }
            }
        }

        public void remove() {
            throw new NotSupportedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
