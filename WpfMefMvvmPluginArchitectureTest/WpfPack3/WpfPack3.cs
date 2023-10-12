using WpfPackInterface;

namespace WpfPack;

[Export(typeof(IPlugin))]
public class WpfPack3 : IPlugin
{
    public WpfPack3()
    {
        PluginName = nameof(WpfPack3);
        PluginView = new WpfPack3View();
        PluginViewModel = new WpfPack3ViewModel();
    }

    public string PluginName { get; init; }
    public object PluginView { get; init; }
    public object PluginViewModel { get; init; }

    public void RegisterServices(IServiceCollection services)
    {
        services.AddTransient<WpfPack3ViewModel>();
        services.AddTransient<WpfPack3View>();
    }
}
