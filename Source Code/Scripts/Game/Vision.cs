public class Vision : Camera
{
    public static Vector2 CameraPos { get; private set; } = new Vector2(200, 100);
    public override void _Process(float delta)
    {
        // Приводим положение на миникарте в соответствие с положением на карте
        CameraPos = new Vector2(Translation.x / 0.625F + 200, Translation.z / 0.625F + 100);
        Vector2 mousePos = GetViewport().GetMousePosition();
        // Двигаем камеру, если мышь достигла края или нажата соответствующая кнопка
        if ((mousePos.x <= 2 || Input.IsActionPressed("ui_left")) && Translation.x > -105)
            Translate(new Vector3(-1, 0, 0));
        else if ((mousePos.x >= 1364 || Input.IsActionPressed("ui_right")) && Translation.x < 100)
            Translate(new Vector3(1, 0, 0));
        if ((mousePos.y <= 2 || Input.IsActionPressed("ui_up")) && Translation.z > -45)
            Translation = new Vector3(Translation.x, 17, Translation.z - 1);
        else if ((mousePos.y >= 766 || Input.IsActionPressed("ui_down")) && Translation.z < 62.5)
            Translation = new Vector3(Translation.x, 17, Translation.z + 1);
        if (mousePos.x > 25 && mousePos.x < 365 && mousePos.y > 593 && Input.IsActionPressed("LeftClick"))
            Translation = (new Vector3(mousePos.x * 0.625F - 125, 20F, mousePos.y * 0.625F - 417.5F));
    }
}