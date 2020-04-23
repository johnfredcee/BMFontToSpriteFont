namespace Cyotek.Drawing.BitmapFont
{
	public struct Size
	{
        private static readonly Size emptySize = new Size();

        public int Width, Height;

        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static Size Empty
        {
            get { return emptySize; }
        }
    }
}