using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace FontExample
{
    class Font
    {
        private static SpriteBatch _spriteBatch;
        private static ContentManager _contentManager;
        private static List<Font> _fonts;

        private SpriteFont _spriteFont;
        private int _size;
        private string _fontName;

        // Initialize font manager
        public static void Initialize(SpriteBatch batch, ContentManager content)
        {
            _spriteBatch = batch;
            _contentManager = content;
            _fonts = new List<Font>();
        }

        // Load an array of font sizes for a given font family
        public static void LoadSizes(string fontName, int[] sizes)
        {
            foreach (int size in sizes)
            {
                _fonts.Add(new Font(fontName, size));
            }
        }
        
        // Regular DrawString function
        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color);
            }
        }

        // Regular DrawString function with automaticScale parameter as fallback
        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color, Boolean automaticScale)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color);
            }
            else if (automaticScale)
            {
                Font closerFont = _fonts.Aggregate((x, y) => Math.Abs(x.Size - size) < Math.Abs(y.Size - size) ? x : y);
                float scalingFactor = (float)size / closerFont.Size;

                _spriteBatch.DrawString(closerFont.SpriteFont, text, position, color, 0, new Vector2(0,0), scalingFactor, SpriteEffects.None, 0);
            }
        }

        // Extended DrawString function with Vector2 scale
        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color, Single rotation, Vector2 origin, Vector2 scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }

        // Extended DrawString function with Single scale
        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color, Single rotation, Vector2 origin, Single scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }

        // Extended DrawString function with automaticScale parameter as fallback
        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color, bool automaticScale, Single rotation, Vector2 origin, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, 1, fx, depth);
            }
            else if (automaticScale)
            {
                Font closerFont = _fonts.Aggregate((x, y) => Math.Abs(x.Size - size) < Math.Abs(y.Size - size) ? x : y);
                float scalingFactor = (float)size / closerFont.Size;

                _spriteBatch.DrawString(closerFont.SpriteFont, text, position, color, rotation, origin, scalingFactor, fx, depth);
            }
        }

        // Regular DrawString function with StringBuilder text
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color);
            }
        }

        // Regular DrawString function with StringBuilder text and automaticScale parameter as fallback
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color, bool automaticScale)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color);
            }
            else if (automaticScale)
            {
                Font closerFont = _fonts.Aggregate((x, y) => Math.Abs(x.Size - size) < Math.Abs(y.Size - size) ? x : y);
                float scalingFactor = (float)size / closerFont.Size;

                _spriteBatch.DrawString(closerFont.SpriteFont, text, position, color, 0, new Vector2(0, 0), scalingFactor, SpriteEffects.None, 0);
            }
        }

        // Extended DrawString function with StringBuilder text and Vector2 scale
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color, Single rotation, Vector2 origin, Vector2 scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }

        // Extended DrawString function with String Builder text and Single scale
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color, Single rotation, Vector2 origin, Single scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }

        // Extended DrawString function with String Builder text and automaticScale as fallback
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color, bool automaticScale, Single rotation, Vector2 origin, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, 1, fx, depth);
            }
            else if (automaticScale)
            {
                Font closerFont = _fonts.Aggregate((x, y) => Math.Abs(x.Size - size) < Math.Abs(y.Size - size) ? x : y);
                float scalingFactor = (float)size / closerFont.Size;

                _spriteBatch.DrawString(closerFont.SpriteFont, text, position, color, rotation, origin, scalingFactor, fx, depth);
            }
        }

        // Retrieve all available sizes for a given font family
        public static List<Font> GetAvailableSizes(string fontName)
        {
            return _fonts.FindAll(f => f.FontName == fontName);
        }

        // Regular measure string by Font parameter
        public static Vector2 MeasureString(Font font, string text)
        {
            return font.SpriteFont.MeasureString(text);
        }

        // Regular measure string by font name and size
        public static Vector2 MeasureString(string fontName, int size, string text)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                return font.SpriteFont.MeasureString(text);
            }

            return new Vector2(0, 0);
        }

        // Regular measure string by font name and size with StringBuilder text
        public static Vector2 MeasureString(string fontName, int size, StringBuilder text)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                return font.SpriteFont.MeasureString(text);
            }

            return new Vector2(0, 0);
        }

        // Font constructor
        public Font(string fontName, int size)
        {
            _spriteFont = _contentManager.Load<SpriteFont>($"{fontName}_{size}");
            _size = size;
            _fontName = fontName;
        }

        // Font getters
        public string FontName { get => _fontName; }
        public int Size { get => _size; }
        public SpriteFont SpriteFont { get => _spriteFont; }
    }
}