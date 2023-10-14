using WpfPackInterface;

namespace WpfMefMvvmPluginArchitectureTest;

public partial class MainViewViewModel : ObservableObject, IViewModel
{
    public MainViewViewModel(PluginManager pluginManager)
    {
        this._pluginManager = pluginManager;

        PluginItems = new ObservableCollection<IPlugin>();
    }

    private readonly PluginManager _pluginManager;

    [ObservableProperty]
    private ObservableCollection<IPlugin> _pluginItems;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Title))]
    private IPlugin? _selectedPluginItem;

    public string Title => $"Now, [{SelectedPluginItem?.PluginName}] Selected.";

    [RelayCommand]
    private void Refresh()
    {
        PluginItems.Clear();
        IEnumerable<IPlugin>? pluginList = _pluginManager.RefreshPlugin();

        if (pluginList is null)
            return;

        foreach (IPlugin item in pluginList)
            PluginItems.Add(item);
    }
}
