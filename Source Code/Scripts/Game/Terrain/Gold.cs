public class Gold : Terrain
{
    public override string TileName { get; protected set; } = "gold";
    public override void OnMouseEntered()
    {
        base.OnMouseEntered();
    }
}
