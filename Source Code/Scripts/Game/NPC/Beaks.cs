public class Beaks : NPC
{
	public override int HP { get; set; }
	public override int MaxHP { get; set; } = 100;
	public override int Damage { get; protected set; } = 20;
	public override float Speed { get; protected set; } = 5;
	protected override void Move(Vector3 dest)
	{
		base.Move(dest);
	}
	public override void _Ready()
	{
		GetChild<AnimationPlayer>(1).Play("Rest");
	}
}
