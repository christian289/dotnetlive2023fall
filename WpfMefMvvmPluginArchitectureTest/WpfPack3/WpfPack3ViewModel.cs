namespace WpfPack;

public partial class WpfPack3ViewModel : ObservableObject
{
    public WpfPack3ViewModel()
    {
        Text = "WpfPack3View!!!!!";
    }

    [ObservableProperty]
    private string? _text;
}
