public class Rock : Terrain
{
    public override string TileName { get; protected set; } = "rock";
    public override void OnMouseEntered()
    {
        base.OnMouseEntered();
    }
}