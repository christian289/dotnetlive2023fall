using WpfPackInterface;

namespace WpfMefMvvmPluginArchitectureTest;

public partial class MainViewViewModel : ObservableObject, IViewModel
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
    [NotifyPropertyChangedFor(nameof(Title))]
    public IPlugin? selectedPluginItem;

    public string Title => $"Now, [{SelectedPluginItem?.PluginName}] Selected.";

    [RelayCommand]
    private void Refresh()
    {
        PluginItems.Clear();
        IEnumerable<IPlugin>? pluginlist = pluginManager.RefreshPlugin();

        if (pluginlist is null)
            return;

        foreach (IPlugin item in pluginlist)
            PluginItems.Add(item);
    }
}
