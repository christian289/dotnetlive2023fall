namespace WpfMefMvvmPluginArchitectureTest;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    public IViewModel? shellContent;
}
