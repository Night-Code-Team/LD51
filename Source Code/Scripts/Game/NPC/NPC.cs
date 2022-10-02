public abstract class NPC : KinematicBody
{
    public abstract int HP { get; protected set; }
    public abstract int Damage { get; protected set; }
    public abstract float Speed { get; protected set; }
    public abstract void ChooseTarget();
    public abstract void Move();
    public abstract void Attack();
    public virtual void Die()
    {
        GetParent().RemoveChild(this);
    }
}