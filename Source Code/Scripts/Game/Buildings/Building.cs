public abstract class Building : Tile
{
    public abstract float HP { get; set; }
    public abstract float Regen { get; set; }
    public Material Red { get; set; }
    public Material Green { get; set; }
    public Material Default { get; set; }
    public bool Available { get; set; }
    public override void _Ready()
    {
        Red = GD.Load<Material>($"res://Assets/Textures/Buildings/{TileName}-red.tres");
        Green = GD.Load<Material>($"res://Assets/Textures/Buildings/{TileName}-green.tres");
        Default = GD.Load<Material>($"res://Assets/Textures/Buildings/{TileName}-default.tres");
    }
    public void Ruin()
    {
        switch (TileName)
        {
            case "mine":
                {
                    return;
                }
            case "lumber":
                {
                    return;
                }
            default:
                {
                    return;
                }
        }
    }
}