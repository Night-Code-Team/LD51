public class Lumbermill : Building
{
    public override float MaxHP { get; set; } = 100;
    public override float HP { get; set; }
    public override string TileName { get; set; } = "lumber";
    public override float Regen { get; set; } = 0;
}
