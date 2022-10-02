public class MapPosition : ColorRect
{
    public override void _Process(float delta)
    {
        MarginLeft = Vision.CameraPos.x - 5;
        MarginRight = Vision.CameraPos.x + 5;
        MarginTop = Vision.CameraPos.y - 5;
        MarginBottom = Vision.CameraPos.y + 5;
    }
}
