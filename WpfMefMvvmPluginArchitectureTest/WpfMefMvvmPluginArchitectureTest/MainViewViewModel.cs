using WpfPackInterface;

namespace WpfMefMvvmPluginArchitectureTest;

public partial class MainViewViewModel : ObservableObject
{
    public MainViewViewModel(PluginManager pluginManager)
    {
        this.pluginManager = pluginManager;

        PluginItems = new ObservableCollection<IPlugin>();
    }

    private readonly PluginManager pluginManager;

    [ObservableProperty]
    public ObservableCollection<IPlugin> pluginItems;

    [ObservableProperty]
    public IPlugin selectedPluginItem;

    [RelayCommand]
    private void Refresh()
    {
        PluginItems.Clear();
        IEnumerable<IPlugin> pluginlist = pluginManager.BuildPluginServiceProvider();

        foreach (IPlugin item in pluginlist)
            PluginItems.Add(item);
    }
}
