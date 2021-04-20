using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CKS_elekctron.NET.Pages
{
    public class SettingsModel : PageModel
    {
        private readonly ILogger<SettingsModel> _logger;

        public SettingsModel(ILogger<SettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
