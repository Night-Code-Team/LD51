public class ArrowTower : Tower
{
    public override string TileName { get; set; } = "arrow-tower";
    public override float MaxHP { get; set; } = 100;
    public override float HP { get; set; }
    public override float Regen { get; set; } = 0.1F;
    public override int Damage { get; set; } = 25;
}