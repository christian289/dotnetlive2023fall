namespace WpfMefMvvmPluginArchitectureTest;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    public object? shellContent;
}
