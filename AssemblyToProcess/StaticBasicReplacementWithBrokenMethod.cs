using HIT.Ionad;

[StaticReplacement(typeof(StaticBasic))]
public class StaticBasicReplacementWithBrokenMethod
{
    public void SomeMethod()
    {
    }
}