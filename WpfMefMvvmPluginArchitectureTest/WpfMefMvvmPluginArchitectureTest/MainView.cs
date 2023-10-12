namespace WpfMefMvvmPluginArchitectureTest;

public class MainView : Control
{
    static MainView()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
    }
}
