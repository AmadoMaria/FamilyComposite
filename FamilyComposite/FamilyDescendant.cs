using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FamilyComposite
{
    public class FamilyDescendant: FamilyComponent
    {
        public string Name { get; set; }
        public bool Artist { get; set; }

        public FamilyDescendant (string name, bool artist)
        {
            Name = name;
            Artist = artist;
        }

        public override string GetName()
        {
            return Name;
        }

        public override bool IsArtist()
        {
            return Artist;
        }

        public override void Print()
        {
            Console.WriteLine(" " + GetName());
            if (IsArtist())
            {
                Console.WriteLine("(artist)");
            }
        }

        public override IEnumerator CreateIterator()
        {
            return null;
        }
    }
}
