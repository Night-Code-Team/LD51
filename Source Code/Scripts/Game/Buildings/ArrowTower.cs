public class ArrowTower : Tower
{
    public override string BuildingName { get; } = "arrow-tower";
    public override float HP { get; set; }
    public override float Regen { get; set; }
    public override int Damage { get; set; }
}