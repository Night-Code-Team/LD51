public class Mine : Building
{
    public override string TileName { get; set; } = "mine";
    public override float MaxHP { get; set; } = 100;
    public override float HP { get; set; }
    public override float Regen { get; set; } = 0;
}
