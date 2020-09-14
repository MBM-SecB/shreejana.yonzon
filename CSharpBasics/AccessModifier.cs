using System;
class AccessModifier
{
    internal int x = 90;
    float y = 214.5f;
    private void DoSomething()
    {

    }
    internal void DoAnotherThing()
    {
        DoSomething();
    }
    private void DoSomething()
    {

    }
    internal void DoAnotherThing()
    {
        DoSomething();
    }
}