using Microsoft.EntityFrameworkCore;
using _3DPrintCostEstimator.Data.Contexts;
using _3DPrintCostEstimator.Data.UnitOfWork;
using _3DPrintCostEstimator.Model;
namespace _3DPrintCostEstimator
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
