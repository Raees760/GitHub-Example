using System.Security.Cryptography.X509Certificates;
using static System.Console;
public class HogwartsStudentRaees : HogwartsStudent
{
    public override string Name { get { return "Raees"; } }
    public HogwartsStudentRaees() : base(100, 20, House.Slytherin) { }

    protected override string SayCatchPhrase()
    {
        return "I'm not a Wizard Hagrid, I'm just Raees!";
    }
    protected override string CastSpell()
    {
        return "Yeetus Fetus";
    }
}
