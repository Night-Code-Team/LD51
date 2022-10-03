public class Katuns : NPC
{
    public override int HP { get; protected set; }
    public override int Damage { get; protected set; }
    public override float Speed { get; protected set; } = 10;
    protected override void Move(Vector3 dest)
    {
        base.Move(dest);
    }
    private void DeathTime()
    {
        GetParent().RemoveChild(this);
    }
    protected override void Attack(Tile target)
    {
        base.Attack(target);
        GetNode<Timer>("Timer2").WaitTime = 1;
        GetNode<Timer>("Timer2").Start();

    }
    public override void _Ready()
    {
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
}