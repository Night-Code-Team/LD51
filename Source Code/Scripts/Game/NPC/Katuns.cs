public class Katuns : NPC
{
    public override int HP { get; protected set; }
    public override int Damage { get; protected set; }
    public override float Speed { get; protected set; } = 10;
    protected override void Move(Vector3 dest)
    {
        base.Move(dest);
    }
    protected override void Attack(Building target)
    {
        base.Attack(target);
    }
    public override void _Ready()
    {
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
}