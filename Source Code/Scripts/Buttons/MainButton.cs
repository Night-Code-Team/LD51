public abstract class MainButton : Button
{

	protected abstract void _OnButtonPressed();
	protected virtual void OnButtonDown(){}
	protected virtual void OnButtonUp(){}
	protected virtual void OnButtonMouseEntered(){}
	protected virtual void OnButtonMouseExited(){}
}
