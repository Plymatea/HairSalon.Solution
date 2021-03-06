#pragma checksum "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a63a02e5904c7876cf70ad450f602b02878dcf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 4 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a63a02e5904c7876cf70ad450f602b02878dcf3", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h4>");
#nullable restore
#line 8 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n  <div class=\"row\">\r\n    <div class=\"col-sm\">\r\n      <h5>Details</h5>\r\n      <ul>\r\n        <li>");
#nullable restore
#line 14 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 14 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"col-sm\">\r\n");
#nullable restore
#line 18 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
       if (@Model.Appointments.Count == 0)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>No Appointments yet!</h5>\r\n");
#nullable restore
#line 21 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
      }  
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Appointments</h5>\r\n        <ul>\r\n");
#nullable restore
#line 26 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
           foreach(Appointment appointment in Model.Appointments)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 28 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
           Write(appointment.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" with ");
#nullable restore
#line 28 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
                                      Write(appointment.Client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 31 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-sm\">\r\n");
#nullable restore
#line 34 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
       if (@Model.Clients.Count == 0)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>No clients yet!</h5>\r\n");
#nullable restore
#line 37 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
      }  
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Clients</h5>\r\n        <ul>\r\n");
#nullable restore
#line 42 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
           foreach(Client client in Model.Clients)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 44 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
           Write(Html.ActionLink($"{client.Name}", "Details", "Clients", new { id = client.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 45 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 47 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n  </div>\r\n<hr/>\r\n<p>");
#nullable restore
#line 51 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Add new Client", "Create", "Clients", new { id = Model.StylistId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n<p>");
#nullable restore
#line 52 "C:\Users\Person\Desktop\Epicodus\HairSalon\Views\Stylists\Details.cshtml"
Write(Html.ActionLink("Back to Stylists", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
