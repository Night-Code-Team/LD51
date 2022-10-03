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
    public override void DeathTime()
    {
        List<Building> list = GetNode<Board>("/root/Root/Board").Buildings;
        foreach (Building building in list)
        {
            if (Translation.DistanceTo(building.Translation) <= 1)
            {
                attack = true;
                building.HP -= Damage;
                return;
            }
        }
        attack = false;
    }
    public override void _Ready()
    {
        GetChild<AnimationPlayer>(1).Play("Rest");
    }
}
