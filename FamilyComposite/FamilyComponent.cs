using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FamilyComposite
{
    public abstract class FamilyComponent
    {
        public virtual void Add(FamilyComponent familyComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(FamilyComponent familyComponent)
        {
            throw new NotSupportedException();
        }

        public virtual FamilyComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public static explicit operator FamilyComponent(bool v)
        {
            throw new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsArtist()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator CreateIterator()
        {
            throw new NotSupportedException();
        }
    }
}
