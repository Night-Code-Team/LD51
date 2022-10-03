public abstract class Tower : Building
{
    public abstract int Damage { get; set; }
    public void Attack()
    {
        Node list = GetNode("/root/Root/Board/Enemies");
        int enemies = list.GetChildCount();
        for (int i = 0; i < enemies; i++)
        {
            if (Translation.DistanceTo(list.GetChild<NPC>(i).Translation) <= 15)
            {
                list.GetChild<NPC>(i).HP -= Damage;
                return;
            }
        }
    }
}