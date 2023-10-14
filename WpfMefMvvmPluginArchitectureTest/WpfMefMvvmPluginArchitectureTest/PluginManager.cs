using WpfPackInterface;

namespace WpfMefMvvmPluginArchitectureTest;

public sealed class PluginManager
{
    public PluginManager()
    {
        string pluginPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");

        if (!Directory.Exists(pluginPath))
            Directory.CreateDirectory(pluginPath);

        _catalog = new DirectoryCatalog("Plugins");
        CompositionContainer container = new(_catalog);
        container.ComposeParts(this);
    }

    private readonly DirectoryCatalog _catalog;

    [ImportMany(typeof(IPlugin), AllowRecomposition = true)]
    private IEnumerable<IPlugin>? Plugins { get; init; } // ImportMany를 통해 동적으로 생성되는 IEnumerable 이기 때문에 set이 필요없다. 또한 init이 없으면 read-only error가 발생한다.

    public IEnumerable<IPlugin>? RefreshPlugin()
    {
        if (Plugins is null)
            return default;

        _catalog.Refresh();

        return Plugins;
    }
}
