using System;
public abstract class NPC : KinematicBody
{
    public abstract int HP { get; protected set; }
    public abstract int Damage { get; protected set; }
    public abstract float Speed { get; protected set; }
    public Vector3 Dest { get; set; } = new Vector3(100, 100, 100);
    protected virtual Vector3 ChooseTarget(List<Building> buildings) => new Vector3(0, 0, 0);
    protected virtual void Move(Vector3 dest)
    {
        Vector3 direction = (dest - Translation).Normalized();
        Vector3 vel = direction * Speed;
        MoveAndSlide(vel);
    }
    protected virtual void Attack(Building target)
    {
        GetNode<AnimationPlayer>("AnimationPlayer").Play("Attack");
    }
    protected virtual void Die()
    {
        GetParent().RemoveChild(this);
    }
    protected virtual void Collision()
    {

    }
    protected void OnTimerTimout()
    {
        GetNode<AnimationPlayer>("AnimationPlayer").Play("Move");
        Dest = ChooseTarget(GetNode<Board>("/root/Root/Board").Buildings);
    }
    public override void _Ready()
    {
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
    public override void _Process(float delta)
    {
        if (Dest != new Vector3(100, 100, 100))
        {
            Move(Dest);
        }
    }
}