public class Forest : Terrain
{
    public override string TileName { get; protected set; } = "forest";
    public override void OnMouseEntered()
    {
        base.OnMouseEntered();
    }
}
