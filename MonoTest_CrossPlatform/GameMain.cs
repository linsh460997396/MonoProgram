using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoMain
{
    public class GameMain : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _pixelBlockTexture;

        //Custom
        Texture2D ballTexture;
        Vector2 ballPosition;
        float ballSpeed;


        public GameMain()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            // 初始化IsMouseVisible，这样你可以在屏幕上看到鼠标
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight / 2);
            ballSpeed = 100f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ballTexture = Content.Load<Texture2D>("ball");

            // 创建一个1x1像素的纹理作为像素块
            //_pixelBlockTexture = new Texture2D(GraphicsDevice, 1, 1);
            //_pixelBlockTexture.SetData(new[] { Color.Red }); // 设置像素为红色

            _pixelBlockTexture = new Texture2D(GraphicsDevice, 5, 5);
            Color[] pixelData = new Color[5 * 5]; // 创建一个包含 25 个元素的数组
            for (int i = 0; i < pixelData.Length; i++)
            {
                pixelData[i] = Color.Red; // 将每个元素设置为红色
            }
            _pixelBlockTexture.SetData(pixelData); // 设置纹理的像素数据
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            var kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Up))
            {
                ballPosition.Y -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Down))
            {
                ballPosition.Y += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Left))
            {
                ballPosition.X -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Right))
            {
                ballPosition.X += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //_spriteBatch.Draw(ballTexture, new Vector2F(0, 0), Color.White);
            //_spriteBatch.Draw(ballTexture, ballPosition, Color.White);
            _spriteBatch.Draw(ballTexture, ballPosition, null, Color.White, 0f, new Vector2(ballTexture.Width / 2, ballTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
            _spriteBatch.Draw(_pixelBlockTexture, new Vector2(200, 200), Color.White); // 在(200, 200)位置绘制像素块

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
