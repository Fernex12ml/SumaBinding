using SumaBinding.ViewModels;

namespace SumaBinding;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new SumaViewModel();
    }
}
