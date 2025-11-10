#if ANDROID
using Android.Views;
#endif

namespace FDMPrintCostEstimator;

public partial class SplashScreen : ContentPage
{
   
    public SplashScreen()
    {
        
        InitializeComponent();
      
    }

    [Obsolete]
    protected override async void OnAppearing()
    {
        base.OnAppearing();
#if ANDROID
        var window = Platform.CurrentActivity?.Window;
        if (window != null)
        {
            window.DecorView.SystemUiVisibility =
                (StatusBarVisibility)(
                    SystemUiFlags.HideNavigation
                    | SystemUiFlags.Fullscreen
                    | SystemUiFlags.ImmersiveSticky
                );
        }
#endif
        await Task.Delay(500);
  
            Application.Current.MainPage = new AppShell();
    }

    [Obsolete]
    protected override void OnDisappearing()
    {
        base.OnDisappearing();

#if ANDROID
        var window = Platform.CurrentActivity?.Window;
        if (window != null)
        {
            window.DecorView.SystemUiVisibility = 0; // przywraca paski
        }
#endif
    }
}