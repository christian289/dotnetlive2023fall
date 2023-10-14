using WpfPackInterface;

namespace WpfPack;

[Export(typeof(IPlugin))]
public sealed class WpfPack1 : IPlugin
{
    public WpfPack1()
    {
        PluginName = nameof(WpfPack1);
        PluginView = new WpfPack1View();
        PluginViewModel = new WpfPack1ViewModel();
    }

    public string PluginName { get; init; }
    public object PluginView { get; init; }
    public object PluginViewModel { get; init; }
}
