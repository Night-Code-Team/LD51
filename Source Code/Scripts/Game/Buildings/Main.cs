public class Main : Building
{
    public override string TileName { get; set; } = "main";
    public override float MaxHP { get; set; } = 800;
    public override float HP { get; set; }
    public override float Regen { get; set; } = 0.1F;
}
