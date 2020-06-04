
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;
using MultiLanguage;
using System.Diagnostics;

namespace MultiLanguage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IStringLocalizer<SharedResource> sharedResouce;
        public IndexModel(IStringLocalizer<SharedResource> _sharedResouce)
        {
            sharedResouce = _sharedResouce;
        }
        public void OnGet()
        {
            var teste = sharedResouce["Msg"];
            Debug.WriteLine("Msg: " + teste);
        }
    }
}