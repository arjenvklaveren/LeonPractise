using Blazor.Extensions.Canvas.Canvas2D;
using System.Numerics;

namespace FirstBlazorApp.Components.ML_Game.GameScreens
{
    public class CreateEnvironment : GameScreen
    {
        Vector2 blockPos = new Vector2(0, 0);

        public override async Task Draw(Canvas2DContext context)
        {
            await context.ClearRectAsync(blockPos.X, blockPos.Y, 100, 100);
            await context.SetFillStyleAsync("rgb(255, 0, 0)");
            await context.FillRectAsync(blockPos.X, blockPos.Y, 100, 100);
        }
    }
}
