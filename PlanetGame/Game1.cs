using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Render.Engine;
using Render.Cameras;
using Render.Objects;


namespace PlanetGame;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private RenderEngine renderEngine;
    public Texture2D PlayerTexture;
    private Sprite PlayerSprite;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        renderEngine = new RenderEngine();
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // create a rectangle texture2d for the player
        PlayerTexture = Content.Load<Texture2D>("player");

        PlayerSprite = new Sprite(PlayerTexture, Vector2.Zero, 0);
        renderEngine.AddSprite(PlayerSprite);
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        if (Keyboard.GetState().IsKeyDown(Keys.W))
            PlayerSprite.position.Y -= 1;
        if (Keyboard.GetState().IsKeyDown(Keys.S))
            PlayerSprite.position.Y += 1;
        if (Keyboard.GetState().IsKeyDown(Keys.A))
            PlayerSprite.position.X -= 1;
        if (Keyboard.GetState().IsKeyDown(Keys.D))
            PlayerSprite.position.X += 1;

        // TODO: Add your update logic here
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        renderEngine.Render(_spriteBatch, new Camera(Vector2.Zero, 1));
        // _spriteBatch.Begin();
        // PlayerSprite.Draw(_spriteBatch);
        // _spriteBatch.End();
        // _spriteBatch.Begin();
        // _spriteBatch.Draw(PlayerTexture, new Vector2(100, 100), Color.White);
        // _spriteBatch.End();

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
