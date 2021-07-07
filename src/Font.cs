using System;
using System.Text;
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

        public static void Initialize(SpriteBatch batch, ContentManager content)
        {
            _spriteBatch = batch;
            _contentManager = content;
            _fonts = new List<Font>();
        }
        public static void LoadSizes(string fontName, int[] sizes)
        {
            foreach (int size in sizes)
            {
                _fonts.Add(new Font(fontName, size));
            }
        }

        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color);
            }
        }
        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color, Single rotation, Vector2 origin, Vector2 scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }

        public static void DrawString(string fontName, int size, string text, Vector2 position, Color color, Single rotation, Vector2 origin, Single scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color);
            }
        }
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color, Single rotation, Vector2 origin, Vector2 scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }
        public static void DrawString(string fontName, int size, StringBuilder text, Vector2 position, Color color, Single rotation, Vector2 origin, Single scale, SpriteEffects fx, Single depth)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                _spriteBatch.DrawString(font.SpriteFont, text, position, color, rotation, origin, scale, fx, depth);
            }
        }

        public static List<Font> GetAvailableSizes(string fontName)
        {
            return _fonts.FindAll(f => f.FontName == fontName);
        }

        public static Vector2 MeasureString(Font font, string text)
        {
            return font.SpriteFont.MeasureString(text);
        }

        public static Vector2 MeasureString(string fontName, int size, string text)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                return font.SpriteFont.MeasureString(text);
            }

            return new Vector2(0, 0);
        }

        public static Vector2 MeasureString(string fontName, int size, StringBuilder text)
        {
            Font font = _fonts.Find(f => f.FontName == fontName && f.Size == size);

            if (font != null)
            {
                return font.SpriteFont.MeasureString(text);
            }

            return new Vector2(0, 0);
        }

        public Font(string fontName, int size)
        {
            _spriteFont = _contentManager.Load<SpriteFont>($"{fontName}_{size}");
            _size = size;
            _fontName = fontName;
        }

        public string FontName { get => _fontName; }
        public int Size { get => _size; }
        public SpriteFont SpriteFont { get => _spriteFont; }
    }
}