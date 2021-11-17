using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FamilyComposite
{
    public class FamilyAncestral : FamilyComponent
    {
        
        public List<FamilyComponent> familyComponents = new List<FamilyComponent>();
        public string Name { get; set; }
        public IEnumerator Iterator { get; set; } = null;

        public override IEnumerator CreateIterator() {
            if (Iterator == null) {
                Iterator = new CompositeIterator(familyComponents.GetEnumerator());
            }
            return Iterator;
        }

    }
}
