public abstract class Building : MeshInstance
{
    public abstract float HP { get; set; }
    public abstract float Regen { get; set; }
    public void Ruin()
    {
    }
    public static void ActivateBuildingMode(string building)
    {
    }
}