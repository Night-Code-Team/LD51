public class Wall : Building
{
    public override string TileName { get; set; } = "wall";
    public override float HP { get; set; }
    public override float Regen { get; set; }
}