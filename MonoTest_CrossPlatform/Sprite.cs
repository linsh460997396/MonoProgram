namespace MonoMain
{
    //切割图片去用的类
    public class Sprite
    {
        //private Texture2D _originalTexture;
        //public Texture2D[] Sprites { get; private set; }

        //public Sprite(Texture2D originalTexture, int spriteWidth, int spriteHeight)
        //{
        //    _originalTexture = originalTexture;
        //    int spriteCountX = _originalTexture.Width / spriteWidth;
        //    int spriteCountY = _originalTexture.Height / spriteHeight;
        //    Sprites = new Texture2D[spriteCountX * spriteCountY];

        //    for (int y = 0; y < spriteCountY; y++)
        //    {
        //        for (int x = 0; x < spriteCountX; x++)
        //        {
        //            int index = y * spriteCountX + x;
        //            Rectangle sourceRectangle = new Rectangle(x * spriteWidth, y * spriteHeight, spriteWidth, spriteHeight);
        //            Sprites[index] = new Texture2D(_originalTexture.GraphicsDevice, spriteWidth, spriteHeight);
        //            Color[] data = new Color[_originalTexture.Width * _originalTexture.Height];
        //            _originalTexture.GetData(data);
        //            Sprites[index].SetData(data, sourceRectangle, data.Length, 0);
        //        }
        //    }
        //}
    }
}

