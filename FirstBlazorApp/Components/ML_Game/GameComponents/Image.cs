using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.AspNetCore.Components;
using System.Numerics;

namespace FirstBlazorApp.Components.ML_Game.GameComponents
{
    public class Image : GameComponent
    {
        string imagePath;

        public Image(Vector2 position, Vector2 size, string imagePath)
        {
            this.position = position;
            this.size = size;
            this.imagePath = imagePath; 
        }

        public override async Task Draw(Canvas2DContext context)
        {
            GetScreen().GetGameCanvas().RenderImageToCanvas(imagePath, position, size);
            await Task.CompletedTask;
        }
    }
}
