public class Rock : Terrain
{
	public override string TileName { get; } = "rock";
	public override void OnMouseEntered()
	{
		base.OnMouseEntered();
	}
}
