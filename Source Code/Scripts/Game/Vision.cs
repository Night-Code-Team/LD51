public class Vision : Camera
{
    public static Vector3 trans;
    public static Vector2 CameraPos { get; private set; } = new Vector2(200, 100);
    public override void _Process(float delta)
    {
        trans = Translation;
        CameraPos = new Vector2(Translation.x / 0.625F + 200, Translation.z / 0.625F + 100);
        Vector2 mousePos = GetViewport().GetMousePosition();
        if ((mousePos.x <= 2 || Input.IsActionPressed("ui_left")) && Translation.x > -125)
        {
            Translate(new Vector3(-1, 0, 0));
        }
        else if ((mousePos.x >= 1364 || Input.IsActionPressed("ui_right")) && Translation.x < 125)
        {
            Translate(new Vector3(1, 0, 0));
        }
        if ((mousePos.y <= 2 || Input.IsActionPressed("ui_up")) && Translation.z > -62.5)
        {
            Translation = new Vector3(Translation.x, 20, Translation.z - 1);
        }
        else if ((mousePos.y >= 766 || Input.IsActionPressed("ui_down")) && Translation.z < 62.5)
        {
            Translation = new Vector3(Translation.x, 20, Translation.z + 1);
        }
        if (mousePos.x < 400 && mousePos.y > 568 && Input.IsActionPressed("LeftClick"))
        {
            Translation = (new Vector3(mousePos.x * 0.625F - 125, 20F, mousePos.y * 0.625F - 417.5F));
        }
    }
}