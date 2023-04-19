
using Hello.OpenTK.WindowUsage;
using OpenTK.Windowing.GraphicsLibraryFramework;

Console.WriteLine("Hello, OpenTK!");

using (var win = new WindowView(800, 600, "Hello.OpenTK.WindowUsage")
{
    KeyboardStateAction = (state, window) =>
    {
        if (state.IsKeyDown(Keys.Space))
        {
            Console.WriteLine("Space is down");
        }

        if (state.IsKeyDown(Keys.Escape))
        {
            window.Close();
        }
    }
})
{
    win.Run();
}

