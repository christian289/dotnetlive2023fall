namespace WpfPack;

public partial class WpfPack2ViewModel : ObservableObject
{
    public WpfPack2ViewModel()
    {
        Text = "WpfPack2View!!!!!";
    }

    [ObservableProperty]
    private string? _text;
}
