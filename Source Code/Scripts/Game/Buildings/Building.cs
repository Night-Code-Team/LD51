public abstract class Building : MeshInstance
{
    public abstract string BuildingName { get; }
    public abstract float HP { get; set; }
    public abstract float Regen { get; set; }
    public Material Red { get; set; }
    public Material Green { get; set; }
    public Material Default { get; set; }
    public bool Available { get; set; }
    public override void _Ready()
    {
        Red = GD.Load<Material>($"res://Assets/Textures/Buildings/{BuildingName}-red.tres");
        Green = GD.Load<Material>($"res://Assets/Textures/Buildings/{BuildingName}-green.tres");
        Default = GD.Load<Material>($"res://Assets/Textures/Buildings/{BuildingName}-default.tres");
    }
    public void Ruin()
    {
        switch (BuildingName)
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
    public void OnMouseEntered()
    {
    }
}