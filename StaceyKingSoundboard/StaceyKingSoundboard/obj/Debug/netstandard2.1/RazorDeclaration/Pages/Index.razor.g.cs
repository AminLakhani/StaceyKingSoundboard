// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StaceyKingSoundboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using StaceyKingSoundboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\_Imports.razor"
using StaceyKingSoundboard.Shared;

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
#line 32 "C:\github\StaceyKingSoundboard\StaceyKingSoundboard\StaceyKingSoundboard\Pages\Index.razor"
 
    public List<Clips> clips;

    protected override async Task OnInitializedAsync()
    {
        var ArrClips = await Http.GetFromJsonAsync<Clips[]>("data/clips.json");
        clips = ArrClips.ToList();
    }

    public class Clips
    {
        public string Title { get; set; }

        public string Mp3Path { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
