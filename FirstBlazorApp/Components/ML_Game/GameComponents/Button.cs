using AngleSharp.Html.Dom.Events;
using Blazor.Extensions.Canvas.Canvas2D;
using Microsoft.AspNetCore.Components.Web;
using System.Numerics;

namespace FirstBlazorApp.Components.ML_Game.GameComponents
{
    public class Button : GameComponent
    {
        Vector3 color;

        public Button(Vector2 position, Vector2 size, Vector3 color)
        {
            this.position = position;
            this.size = size;
            this.color = color;
        }

        public override async Task Draw(Canvas2DContext context)
        {
            await context.ClearRectAsync(position.X, position.Y, size.X, size.Y);
            await context.SetFillStyleAsync("rgb(" + color.X.ToString() + "," + color.Y.ToString() + "," + color.Z.ToString() + ")");
            await context.FillRectAsync(position.X, position.Y, size.X, size.Y);
        }

        public bool OnClick()
        {
            return true;
        }
    }
}
