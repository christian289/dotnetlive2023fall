namespace WpfMefMvvmPluginArchitectureTest;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private IViewModel? _shellContent;
}
