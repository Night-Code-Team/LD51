public class MagicTower : Tower
{
	public override string TileName { get; set; } = "magic-tower";
	public override float HP { get; set; }
	public override float Regen { get; set; }
	public override int Damage { get; set; }
}
