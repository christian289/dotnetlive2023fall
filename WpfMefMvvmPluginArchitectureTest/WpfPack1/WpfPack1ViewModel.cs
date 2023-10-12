namespace WpfPack;

public partial class WpfPack1ViewModel : ObservableObject
{
    public WpfPack1ViewModel()
    {
        Text = "WpfPack1View!!!!!";
    }

    [ObservableProperty]
    public string? text;
}
