using WpfPackInterface;

namespace WpfPack;

[Export(typeof(IPlugin))]
public class WpfPack2 : IPlugin
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

    public void RegisterServices(IServiceCollection services)
    {
        services.AddTransient<WpfPack2ViewModel>();
        services.AddTransient<WpfPack2View>();
    }
}
