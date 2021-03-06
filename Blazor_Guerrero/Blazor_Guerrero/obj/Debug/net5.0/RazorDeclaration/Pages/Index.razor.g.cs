// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Guerrero.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Blazor_Guerrero;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Blazor_Guerrero\Blazor_Guerrero\_Imports.razor"
using Blazor_Guerrero.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Blazor_Guerrero\Blazor_Guerrero\Pages\Index.razor"
            
    RatingObject[] ratings;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var url = @"https://api.npoint.io/d0e9ee2028a691c2c836";


        ratings = await Http.GetFromJsonAsync<RatingObject[]>(url);

        // Let average it!
        var aResult = ratings
        .GroupBy(x => x.City)
        .Select(x => new
        {
            City = x.Key,
            Rating = x.Average(x => x.Rating)
        }).ToList();

        int inc = 0;

        // Lets loop and assign.
        foreach (var aR in aResult)
        {
            foreach (var iTg in ratings)
            {
                if (iTg.City.Equals(aR.City))
                {
                    inc = iTg.ID - 1;

                    ratings[inc].Avg = aR.Rating;
                }
                continue;
            }
        }
    }

    class RatingObject
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string Cuisine { get; set; }
        public int Rating { get; set; }
        public double Avg { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
