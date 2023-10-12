namespace WpfMefMvvmPluginArchitectureTest;

public partial class App : Application
{
    public IServiceProvider Container { get; private set; }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        IServiceCollection collection = new ServiceCollection();
        collection.AddSingleton<PluginManager>();
        collection.AddSingleton<MainWindow>();
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddSingleton<MainView>();
        collection.AddSingleton<MainViewViewModel>();
        Container = collection.BuildServiceProvider();

        MainWindow? mainWindow = Container.GetRequiredService<MainWindow>();
        MainWindowViewModel windowvm = Container.GetRequiredService<MainWindowViewModel>();
        windowvm.ShellContent = Container.GetRequiredService<MainViewViewModel>();
        mainWindow.DataContext = windowvm;
        mainWindow.Show();
    }
}
