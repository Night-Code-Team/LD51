using System;
public abstract class NPC : KinematicBody
{
    public abstract int HP { get; protected set; }
    public abstract int Damage { get; protected set; }
    public abstract float Speed { get; protected set; }
    public static Vector3 Dest { get; set; } = new Vector3(100, 100, 100);
    private bool attack = false;
    private KinematicCollision collision = null;
    Tile collider = null;
    protected virtual void Move(Vector3 dest)
    {
        Vector3 direction = (dest - Translation).Normalized();
        Vector3 vel = direction * Speed;
        MoveAndSlide(vel);
        for (int i = 0; i < GetSlideCount(); i++)
            collision = GetSlideCollision(i);
        if (collision != null)
            try
            {
                collider = ((KinematicBody)(collision.Collider)).GetParent<Tile>();
            }
            catch
            {
                collider = null;
            }
        else
        {
            attack = false;
        }
        if (collider != null)
        {
            if (collider.TileName == "wall" || collider.TileName == "mine"
                || collider.TileName == "main" || collider.TileName == "arrow-tower"
                    || collider.TileName == "magic-tower" || collider.TileName == "lumber")
            {
                attack = true;
                Attack(collider);
            }
        }
    }
    protected virtual void Attack(Tile target)
    {
        GetNode<AnimationPlayer>("AnimationPlayer").Play("Attack");
        GetNode<AudioStreamPlayer3D>("AudioStreamPlayer3D").Play();
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
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
    public override void _PhysicsProcess(float delta)
    {
        if (!attack && Dest != new Vector3(100, 100, 100))
        {
            GetNode<AnimationPlayer>("AnimationPlayer").Play("Move");
            Move(Dest);
        }
    }
}