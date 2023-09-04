using System.Security.Cryptography.X509Certificates;
using static System.Console;
public class HogwartsStudentKyrone : HogwartsStudent
{
    public override string Name { get { return "Kyrone"; } }
    public HogwartsStudentKyrone() : base(100, 20, House.Slytherin) { }

    protected override string SayCatchPhrase()
    {
        return "I used to be a Wizard just like you, till I took a spell to the knee!";
    }
    protected override string CastSpell()
    {
        return "STFU";
    }
}
