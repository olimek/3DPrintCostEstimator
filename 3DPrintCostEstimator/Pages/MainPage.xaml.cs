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

            if (_userDataService.GetUser() is null)
            {
                await Navigation.PushAsync(
                    new UserDataFormPage(_userDataService)
                );
            }
            var dupa = _userDataService.GetUser();
        }
    }
}