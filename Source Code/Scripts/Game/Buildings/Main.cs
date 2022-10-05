public class Main : Building
{
	public override string TileName { get; set; } = "main";
	public override float MaxHP { get; set; } = 800;
	public override float HP { get; set; }
	public override float Regen { get; set; } = 0.1F;
	public override (int, int) Cost { get; protected set; } = (500, 300);
	public override void Ruin()
	{
		GetTree().ChangeScene("res://Assets/Scenes/Main Menu/Main Menu.tscn");
	}
}
