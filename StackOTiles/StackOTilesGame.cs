using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StackOTiles.Screens;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Net;
using System.Reflection;
using StackOTiles.Networking;
using StackOTiles.Graphics;
using StackOTiles.ArtificialIntelligence;

namespace StackOTiles
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class StackOTilesGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        ScreenManager screenManager;

        public StackOTilesGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;

			graphics.IsFullScreen = true;

            // Create the screen manager component.
            screenManager = new ScreenManager(this);

            Components.Add(screenManager);

            // load the initial screens
            screenManager.AddScreen(new SplashScreen(screenManager), null);

            // Listen for invite notification events.
			// TODO
//            NetworkSession.InviteAccepted += (sender, e)
//                => NetworkSessionComponent.InviteAccepted(screenManager, e);

            // To test the trial mode behavior while developing your game,
            // uncomment this line:

            // Guide.SimulateTrialMode = true;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            base.Draw(gameTime);
        }
    }
}
