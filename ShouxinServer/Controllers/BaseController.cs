using System.Web.Mvc;
using ShouxinServer.ViewModels;

namespace ShouxinServer.Controllers
{
    public class BaseController:Controller
    {
         protected virtual BaseViewModel GetViewModel()
         {
             var viewModel = new BaseViewModel();
             return viewModel;
         }
    }
}