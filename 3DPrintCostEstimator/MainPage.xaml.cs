using Microsoft.EntityFrameworkCore;
using FDMPrintCostEstimator.Data.Contexts;
using FDMPrintCostEstimator.Data.UnitOfWork;
using FDMPrintCostEstimator.Model;
namespace FDMPrintCostEstimator
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
