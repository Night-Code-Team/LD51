public class MSAA : WorldEnvironment
{
	public override void _Ready()
	{
		GetViewport().Msaa = Viewport.MSAA.Msaa8x;
	}
}
