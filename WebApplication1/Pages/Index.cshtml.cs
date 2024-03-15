using MaktabBank.Core.Core.Interface.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBankAccountAppServices _bankAccountAppServices;


        public IndexModel(ILogger<IndexModel> logger, IBankAccountAppServices bankAccountAppServices)
        {
            _logger = logger;
            _bankAccountAppServices = bankAccountAppServices;
        }

        public void OnGet()
        {

        }

        public void TransferMoney(string fromCard,string toCard,int money, string password)
        {
            _bankAccountAppServices.TransferMoney(fromCard,toCard,money,password);
        }
    }
}