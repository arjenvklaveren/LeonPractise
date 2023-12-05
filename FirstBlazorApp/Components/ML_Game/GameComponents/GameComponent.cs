using Blazor.Extensions.Canvas.Canvas2D;
using System.Numerics;

namespace FirstBlazorApp.Components.ML_Game.GameComponents
{
    public abstract class GameComponent
    {
        protected Vector2 position;
        protected Vector2 size;

        GameScreens.GameScreen myScreen = null;

        public void Translate(Vector2 vector) { position += vector; }
        public void Scale(Vector2 vector) { size += vector; }

        public void SetPosition(Vector2 vector) { position = vector; }
        public void SetSize(Vector2 vector) { size = vector; }

        public Vector2 GetPosition() { return position; }
        public Vector2 GetSize() { return size; }

        public void SetScreen(GameScreens.GameScreen screen) { myScreen = screen; }
        public GameScreens.GameScreen GetScreen() { return myScreen; }

        public virtual async Task Draw(Canvas2DContext context) { await Task.CompletedTask; }
        public virtual void Update() { }
    }
}
