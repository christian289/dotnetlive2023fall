namespace WpfPack;

public partial class WpfPack2ViewModel : ObservableObject
{
    public WpfPack2ViewModel()
    {
        Text = "WpfPack2View!!!!!";
    }

    [ObservableProperty]
    public string? text;
}
