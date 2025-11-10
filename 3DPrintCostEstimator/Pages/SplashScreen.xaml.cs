#if ANDROID
using Android.Views;
using System.Runtime.Versioning; 
#endif

namespace FDMPrintCostEstimator.Pages
{
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

#if ANDROID
        [SupportedOSPlatform("android30.0")]
#endif
        protected override async void OnAppearing()
        {
            base.OnAppearing();

#if ANDROID
            var window = Platform.CurrentActivity?.Window;
            var controller = window?.InsetsController;

            if (controller != null)
            {
                controller.Hide(WindowInsets.Type.StatusBars() | WindowInsets.Type.NavigationBars());
                controller.SystemBarsBehavior =
                    (int)WindowInsetsControllerBehavior.ShowTransientBarsBySwipe;
            }
#endif

            await Task.Delay(500);

            var windowInstance = Application.Current?.Windows?.FirstOrDefault();
            if (windowInstance != null)
                windowInstance.Page = new AppShell();
        }

#if ANDROID
        [SupportedOSPlatform("android30.0")]
#endif
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

#if ANDROID
            var window = Platform.CurrentActivity?.Window;
            var controller = window?.InsetsController;

            controller?.Show(WindowInsets.Type.StatusBars() | WindowInsets.Type.NavigationBars());
#endif
        }
    }
}
