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

        public FamilyAncestral(string name){
            this.Name = name;
        }

        public override void Add(FamilyComponent familyComponent) {
            familyComponents.Add(familyComponent);
        }

        public override void Remove(FamilyComponent familyComponent) {
            familyComponents.Remove(familyComponent);
        }

        public override string GetName() {
            return this.Name;
        }

        public override void Print() {
            Console.WriteLine("\n" + GetName());        
            Console.WriteLine("----------------------");

            IEnumerator Iterator = familyComponents.GetEnumerator();
            while (Iterator.MoveNext()) {
                FamilyComponent familyComponent = (FamilyComponent)Iterator.Current;
                familyComponent.Print();
            }
        }

        public override CompositeIterator CreateIterator() {
            if (Iterator == null) {
                Iterator = new CompositeIterator(familyComponents.GetEnumerator());
            }
            return (CompositeIterator)Iterator;
        }

    }
}
