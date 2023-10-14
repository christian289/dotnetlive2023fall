using WpfPackInterface;

namespace WpfPack;

[Export(typeof(IPlugin))]
public sealed class WpfPack2 : IPlugin
{
    public WpfPack2()
    {
        PluginName = nameof(WpfPack2);
        PluginView = new WpfPack2View();
        PluginViewModel = new WpfPack2ViewModel();
    }

    public string PluginName { get; init; }
    public object PluginView { get; init; }
    public object PluginViewModel { get; init; }
}
