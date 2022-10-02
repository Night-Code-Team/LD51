public class MapPosition : ColorRect
{
    public override void _Process(float delta)
    {
        // Меняем положение рамки на миникарте
        MarginLeft = Vision.CameraPos.x - 36;
        MarginRight = Vision.CameraPos.x + 36;
        MarginTop = Vision.CameraPos.y - 18;
        MarginBottom = Vision.CameraPos.y + 18;
    }
}