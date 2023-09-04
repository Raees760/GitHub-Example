using System.Security.Cryptography.X509Certificates;
using static System.Console;
public class HogwartsStudentSimon : HogwartsStudent
{
    public override string Name { get { return "Simon"; } }
    public HogwartsStudentSimon() : base(100, 20, House.Slytherin) { }

    protected override string SayCatchPhrase()
    {
        return "KILL HIM! KIIIILLL HIIIIMMM";
    }
    protected override string CastSpell()
    {
        return "I Cast Fist";
    }
}
