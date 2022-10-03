public class Rock : Terrain
{
	public override string TileName { get; set; } = "rock";
	public override void OnMouseEntered()
	{
		base.OnMouseEntered();
	}
}
