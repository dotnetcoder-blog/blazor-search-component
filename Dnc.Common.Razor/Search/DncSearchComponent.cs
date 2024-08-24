using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnc.Common.Razor.Search
{
    public class DncSearchComponent<TItem> : ComponentBase
    {
        [Parameter]
        public EventCallback<string> OnSearch { get; set; }

        [Parameter]
        public string PlaceholderText { get; set; } = "Search...";

        [Parameter]
        public string ButtonText { get; set; } = "Search";

        [Parameter]
        public string CssButton { get; set; } = "btn-primary";

        protected string searchTerm;
        protected async Task HandleSearch()
        {
            await OnSearch.InvokeAsync(searchTerm);
        }

        protected async Task HandleEnter(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                await OnSearch.InvokeAsync(searchTerm);
            }
        }
    }
}
