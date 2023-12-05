using Blazor.Extensions.Canvas.Canvas2D;
using System.Numerics;

namespace FirstBlazorApp.Components.ML_Game.GameScreens
{
    public class MainMenu : GameScreen
    {
        GameComponents.Image img1;
        GameComponents.Image img2;

        GameComponents.Button button1;

        public MainMenu()
        {
            img1 = new GameComponents.Image(new Vector2(0, 0), new Vector2(100, 100), "Images/testImage.jpg");
            AddGameComponent(img1);
            img2 = new GameComponents.Image(new Vector2(200, 200), new Vector2(50, 50), "Images/testImage.jpg");
            AddGameComponent(img2);
             
            button1 = new GameComponents.Button(new Vector2(350,350), new Vector2(100,100), new Vector3(0,0,255));
            AddGameComponent(button1);
        }

        public override async Task Draw(Canvas2DContext context)
        {
            await img1.Draw(context);
            await img2.Draw(context);
            await button1.Draw(context);
        }
        public override void Update()
        {
            img2.Translate(new Vector2(1, 1));
            button1.OnClick();
        }
    }
}

