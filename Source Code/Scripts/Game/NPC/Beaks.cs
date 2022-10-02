using System;
public class Beaks : NPC
{
    public override int HP { get; protected set; }
    public override int Damage { get; protected set; }
    public override float Speed { get; protected set; }
    public override void ChooseTarget()
    {
        throw new NotImplementedException();
    }
    public override void Move()
    {
        throw new NotImplementedException();
    }
    public override void Attack()
    {
        throw new NotImplementedException();
    }

}