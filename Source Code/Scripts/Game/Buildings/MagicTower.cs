public class MagicTower : Tower
{
    public override string TileName { get; set; } = "magic-tower";
    public override float MaxHP { get; set; } = 200;
    public override float HP { get; set; }
    public override float Regen { get; set; } = 0.1F;
    public override int Damage { get; set; } = 50;
}
