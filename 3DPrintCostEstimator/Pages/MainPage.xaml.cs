using FDMPrintCostEstimator.Data.UnitOfWork;

namespace FDMPrintCostEstimator.Pages

{
    public partial class MainPage : ContentPage
    {
        private readonly IUnitOfWork _unitOfWork;

        public MainPage(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            _unitOfWork.UserData.GetAll();
        }
    }
}