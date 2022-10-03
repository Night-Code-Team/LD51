public class Katuns : NPC
{
    public override int HP { get; set; }
    public override int MaxHP { get; set; } = 50;
    public override int Damage { get; protected set; } = 100;
    public override float Speed { get; protected set; } = 7.5F;
    Building target;
    protected override void Move(Vector3 dest)
    {
        base.Move(dest);
    }
    private void DeathTime()
    {
        base.Attack(target);
        GetParent().RemoveChild(this);
    }
    protected override void Attack(Building target)
    {
        this.target = target;
        GetNode<Timer>("Timer2").WaitTime = 1;
        GetNode<Timer>("Timer2").Start();

    }
    public override void _Ready()
    {
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
}