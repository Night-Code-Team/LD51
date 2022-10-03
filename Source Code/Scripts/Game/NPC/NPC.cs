using System;
public abstract class NPC : KinematicBody
{
    public abstract int HP { get; set; }
    public abstract int MaxHP { get; set; }
    public abstract int Damage { get; protected set; }
    public abstract float Speed { get; protected set; }
    public static Vector3 Dest { get; set; } = new Vector3(100, 100, 100);
    protected bool attack = false;
    Tile collider = null;
    protected virtual void Move(Vector3 dest)
    {
        Vector3 direction = (dest - Translation).Normalized();
        Vector3 vel = direction * Speed;
        LookAt(dest, new Vector3(0, 1, 0));
        MoveAndSlide(vel);
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
        Dest = Board.Main;
        GetNode<AnimationPlayer>("AnimationPlayer").Play("Move");
    }
    public override void _Ready()
    {
        HP = MaxHP;
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
    public virtual void DeathTime()
    {
        List<Building> list = GetNode<Board>("/root/Root/Board").Buildings;
        foreach (Building building in list)
        {
            if (Translation.DistanceTo(building.Translation) <= 1)
            {
                GetChild<AnimationPlayer>(1).Play("Attack");
                attack = true;
                building.HP -= Damage;
                return;
            }
        }
        attack = false;
        return;
    }
    public override void _PhysicsProcess(float delta)
    {
        if (HP < 0)
        {
            GetParent().RemoveChild(this);
        }
        if (!attack && Dest != new Vector3(100, 100, 100))
        {
            GetNode<AnimationPlayer>("AnimationPlayer").Play("Move");
            Move(Dest);
        }
    }
}