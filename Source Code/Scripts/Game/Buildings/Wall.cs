public class Wall : Building
{
    public override string TileName { get; set; } = "wall";
    public override float MaxHP { get; set; } = 300;
    public override float HP { get; set; }
    public override float Regen { get; set; } = 0.2F;

    public override (int, int) Cost { get; protected set; } = (30, 10);
}