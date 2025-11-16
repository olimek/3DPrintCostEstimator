using FDMPrintCostEstimator.Model;
using FDMPrintCostEstimator.Service;

namespace FDMPrintCostEstimator.Pages
{
    public partial class UserDataFormPage : ContentPage
    {
        private readonly IUserDataService _userDataService;
        private UserData? _current;

        public UserDataFormPage(IUserDataService userDataService)
        {
            InitializeComponent();
            _userDataService = userDataService;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadData();
        }

        private void LoadData()
        {
            _current = _userDataService.GetUser();

            if (_current != null)
            {
                CostEntry.Text = _current.Cost1kWh.ToString("0.##");
                CurrencyEntry.Text = _current.CurencySymbol;
            }
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            double cost = double.Parse(CostEntry.Text.Replace(".", ","));
            string currency = CurrencyEntry.Text?.Trim() ?? string.Empty;

            if (_current == null)
            {
                _current = new UserData
                {
                    Cost1kWh = cost,
                    CurencySymbol = currency,
                    Filament = new List<Filaments>(),
                    Printer = new List<Printers>()
                };
            }
            else
            {
                _current.Cost1kWh = cost;
                _current.CurencySymbol = currency;
            }

            _userDataService.Save(_current);

            await DisplayAlert("Sukces", "Dane użytkownika zapisane.", "OK");
            await Navigation.PopAsync();
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(CostEntry.Text))
            {
                DisplayAlert("Błąd", "Musisz podać koszt 1 kWh.", "OK");
                return false;
            }

            if (!double.TryParse(CostEntry.Text.Replace(".", ","), out _))
            {
                DisplayAlert("Błąd", "Niepoprawny format kosztu (tylko liczby).", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(CurrencyEntry.Text))
            {
                DisplayAlert("Błąd", "Musisz podać symbol waluty.", "OK");
                return false;
            }

            return true;
        }
    }
}