using System;

namespace FamilyComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyAncestral maria = new FamilyAncestral("Bisavó Maria");
            FamilyAncestral joana = new FamilyAncestral("Avô Joana");
            FamilyAncestral luisa = new FamilyAncestral("Avó Luisa");
            FamilyAncestral sandra = new FamilyAncestral("Mãe Sandra");

            FamilyDescendant carla = new FamilyDescendant("Carla", true);
            FamilyDescendant bia = new FamilyDescendant("Bia", false);
            FamilyDescendant diana = new FamilyDescendant("Diana",false);
            FamilyDescendant malu = new FamilyDescendant("Malu", true);
            FamilyDescendant sofia = new FamilyDescendant("Sofia", true);

            maria.Add(joana);
            maria.Add(luisa);

            joana.Add(carla);
            joana.Add(bia);

            luisa.Add(diana);
            luisa.Add(sandra);

            sandra.Add(malu);
            sandra.Add(sofia);

            Client client = new Client(maria);

            client.PrintLeafArtistComponents();

        }
    }
}
