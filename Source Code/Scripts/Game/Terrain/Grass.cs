public class Grass : Terrain
{
    public override string TileName { get; protected set; } = "grass";
    public override void OnMouseEntered()
    {
        base.OnMouseEntered();
    }
}
