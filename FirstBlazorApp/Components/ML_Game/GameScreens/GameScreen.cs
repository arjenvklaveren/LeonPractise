using Blazor.Extensions.Canvas.Canvas2D;

namespace FirstBlazorApp.Components.ML_Game.GameScreens
{
    public abstract class GameScreen
    {
        GameCanvas myGameCanvas = null;
        List<GameComponents.GameComponent> components = new List<GameComponents.GameComponent>();

        public async virtual Task Draw(Canvas2DContext context) { await Task.CompletedTask; }
        public virtual void Update() { }

        public void AddGameComponent(GameComponents.GameComponent component) 
        {  
            components.Add(component); 
            component.SetScreen(this);
        }    

        public void SetGameCanvas(GameCanvas gameCanvas) {  myGameCanvas = gameCanvas; }
        public GameCanvas GetGameCanvas() { return myGameCanvas; }
    }
}
