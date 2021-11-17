using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FamilyComposite
{
    public class Client
    {
        public FamilyComponent AllComponents { get; set; }

        public Client( FamilyComponent allComponents)
        {
            AllComponents = allComponents;
        }

        public void PrintComponent()
        {
            AllComponents.Print();
        }

        public void PrintArtistComponents() {
            IEnumerator iterator = AllComponents.CreateIterator();
            Console.WriteLine("\nARTIST COMPONENTS\n------");
            while(iterator.MoveNext()) {
                FamilyComponent familyComponent = (FamilyComponent)iterator;
                try {
                    if (familyComponent.IsArtist()){
                        familyComponent.Print();
                    }
                } catch (NotSupportedException e) { }
            }
        }
    }
}
