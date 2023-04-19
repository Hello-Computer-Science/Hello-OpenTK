using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Hello.OpenTK.WindowUsage;

public class WindowView : GameWindow
{
    public Action<FrameEventArgs>? OnUpdateFrameAction { get; set; } = null;

    public Action<KeyboardState, GameWindow>? KeyboardStateAction { get; set; } = null;

    public WindowView(int width, int height, string title)
        : base(GameWindowSettings.Default, new NativeWindowSettings() { Size = (width, height), Title = title })
    {

    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        OnUpdateFrameAction?.Invoke(e);

        KeyboardStateAction?.Invoke(KeyboardState, this);
    }
}

