using System.Security.Cryptography.X509Certificates;
using static System.Console;
public class HogwartsStudentKayla : HogwartsStudent
{
    public override string Name { get { return "Kayla"; } }
    public HogwartsStudentKayla() : base(100, 20, House.Slytherin) { }

    protected override string SayCatchPhrase()
    {
        return "This Fucking Laptop!";
    }
    protected override string CastSpell()
    {
        return "Summon Familiar";
    }
}
