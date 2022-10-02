public class Katuns : NPC
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
    public override void _Ready()
    {
        GetChild<AnimationPlayer>(1).Play("Attack");
    }
    public override void _Process(float delta)
    {
        MoveAndSlide(new Vector3(1, 0, 0));
    }
}