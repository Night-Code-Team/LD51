public class Wall : Building
{
	public override string BuildingName { get; } = "wall";
	public override float HP { get; set; }
	public override float Regen { get; set; }
}
