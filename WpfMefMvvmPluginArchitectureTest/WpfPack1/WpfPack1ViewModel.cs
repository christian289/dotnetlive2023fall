namespace WpfPack;

public partial class WpfPack1ViewModel : ObservableObject
{
    public WpfPack1ViewModel()
    {
        Text = "WpfPack1View!!!!!";
    }

    [ObservableProperty]
    private string? _text;
}
