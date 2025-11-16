using FDMPrintCostEstimator.Service;

namespace FDMPrintCostEstimator.Pages

{
    public partial class MainPage : ContentPage
    {
        private readonly IUserDataService _userDataService;

        public MainPage(IUserDataService userDataService)
        {
            InitializeComponent();
            _userDataService = userDataService;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var userData = _userDataService.GetUser();
            if (userData is null)
            {
                await Navigation.PushAsync(
                    new UserDataFormPage(_userDataService)
                );
            }
        }
    }
}