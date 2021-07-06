# MonoGame Font Size Wrapper

A simple wrapper for handling various font sizes for a given font family with ease in MonoGame.

## Description

While MonoGame allows you to provide a scaling factor when drawing text, it will probably look blurred or jagged because it is effectively up-scaling or down-scaling the bitmap generated from the size you provided in the original SpriteFont. The alternative is to load all the font sizes you need for a given font family and use them interchangeably, but even then it becomes a chore to load and manage them. Hence the creation of this little wrapper.

In a nutshell, it's just a simpler way to load font families with different sizes, managing and drawing text using them. 

Note: You can still use the scaling factor. If you have loaded a SpriteFont with size 36pt and there's this one part where you want to draw some text with size 38pt, it's probably better to just draw the text with the size 36pt and a scaling factor of 1.06f than creating a new bitmap for the size 38pt.

## Installation

Just copy the ``Font``class into your project and you're ready to go.

## Usage
When loading your font families on the MGCB Editor, just make sure you load them using the NAME_SIZE template (eg. Arial_32) or change the ``Font.LoadSizes`` method accordingly.
```c#
# Initialize the wrapper in the LoadContent method
Font.Initialize(_spriteBatch, Content);

# Load your array of sizes for a given font family in the LoadContent method
Font.LoadSizes("Arial", new int[] { 12, 16, 24, 32, 48, 72 });

# Get all available sizes for a given font
List<Font> fonts = Font.GetAvailableSizes("Arial");

# Write text to the screen by specifying font name and size in the Draw method
Font.DrawString("Arial", 32, "Hello, world", new Vector2(8, 8), Color.White);
```
For compatibility and ease of use, the methods normally used by MonoGame's SpriteFont and SpriteBatch are implemented using the same names. So ``SpriteBatch.DrawString`` becomes ``Font.DrawString`` where the first two parameters are font name and size respectively instead of a direct SpriteFont reference. The same thing happens to ``SpriteFont.MeasureString`` where you can call ``Font.MeasureString`` and pass either a Font object or a font name and size along with the text to measure.

## Example
Here's a simple example.

```c#
# In the LoadContent method
Font.Initialize(_spriteBatch, Content);
Font.LoadSizes("Arial", new int[] { 12, 16, 24, 32, 48, 72 });

# In the Draw method
List<Font> fonts = Font.GetAvailableSizes("Arial");

for (int i = 0; i < fonts.Count; i++)
{
    Font font = fonts[i];
    Vector2 measuredString = Font.MeasureString(font, "Hello, world!");

    Font.DrawString(font.FontName, font.Size, $"Hello, world! {measuredString.X},{measuredString.Y}", new Vector2(8, 72 * i + 8), Color.White);
}
```
If everything goes according to plan, you should see something like [this](https://joaomakes.games/wp-content/uploads/FontExample.png).

## Contributing
Feel free to contribute if you feel like something could use some work. 

## License
[The MIT License (MIT)](https://choosealicense.com/licenses/mit/)