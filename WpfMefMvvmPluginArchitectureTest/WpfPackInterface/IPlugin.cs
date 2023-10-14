namespace WpfPackInterface;

public interface IPlugin
{
    string PluginName { get; init; }
    object PluginView { get; init; }
    object PluginViewModel { get; init; }
}
