#pragma checksum "C:\commit\artec\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b9857ef152426ff027c88f9b45d56c958be5376"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\commit\artec\Views\_ViewImports.cshtml"
using artec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\commit\artec\Views\_ViewImports.cshtml"
using artec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b9857ef152426ff027c88f9b45d56c958be5376", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"504dcb136d1622c0f2dbe7784dba1b6aa82dfd63", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\commit\artec\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row row-cols-1 row-cols-md-3 g-4"">
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Dibujo</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 374, "\"", 427, 3);
            WriteAttributeValue("", 384, "location.href=\'", 384, 15, true);
#nullable restore
#line 12 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 399, Url.Action("Ir", "Dibujo"), 399, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 426, "\'", 426, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Pintura</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 758, "\"", 812, 3);
            WriteAttributeValue("", 768, "location.href=\'", 768, 15, true);
#nullable restore
#line 22 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 783, Url.Action("Ir", "Pintura"), 783, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 811, "\'", 811, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Murales</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 1143, "\"", 1197, 3);
            WriteAttributeValue("", 1153, "location.href=\'", 1153, 15, true);
#nullable restore
#line 32 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 1168, Url.Action("Ir", "Murales"), 1168, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1196, "\'", 1196, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  </div>
  <div class=""row row-cols-1 row-cols-md-3 g-4"">
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Tatuajes</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 1589, "\"", 1644, 3);
            WriteAttributeValue("", 1599, "location.href=\'", 1599, 15, true);
#nullable restore
#line 44 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 1614, Url.Action("Ir", "Tatuajes"), 1614, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1643, "\'", 1643, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Cosplay</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 1975, "\"", 2029, 3);
            WriteAttributeValue("", 1985, "location.href=\'", 1985, 15, true);
#nullable restore
#line 54 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 2000, Url.Action("Ir", "Cosplay"), 2000, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2028, "\'", 2028, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">M??sica</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 2359, "\"", 2412, 3);
            WriteAttributeValue("", 2369, "location.href=\'", 2369, 15, true);
#nullable restore
#line 64 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 2384, Url.Action("Ir", "Musica"), 2384, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2411, "\'", 2411, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  </div>
  <div class=""row row-cols-1 row-cols-md-3 g-4"">
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""C:\Users\victo\Desktop\Fotos\g3.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Danza-Expresi??n Corporal</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 2841, "\"", 2893, 3);
            WriteAttributeValue("", 2851, "location.href=\'", 2851, 15, true);
#nullable restore
#line 76 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 2866, Url.Action("Ir", "Danza"), 2866, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2892, "\'", 2892, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Ceramica</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 3225, "\"", 3280, 3);
            WriteAttributeValue("", 3235, "location.href=\'", 3235, 15, true);
#nullable restore
#line 86 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 3250, Url.Action("Ir", "Ceramica"), 3250, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3279, "\'", 3279, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Ir</button>
      </div>
    </div>
  </div>
  <div class=""col"">
    <div class=""card h-100"">
      <img src=""../../gato.jpg"" class=""card-img-top"" alt=""..."">
      <div class=""card-body"">
        <h5 class=""card-title"">Producci??n Audiovisual</h5>
        <p class=""card-text"">...</p>
        <button class=""btn btn-info"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 3626, "\"", 3684, 3);
            WriteAttributeValue("", 3636, "location.href=\'", 3636, 15, true);
#nullable restore
#line 96 "C:\commit\artec\Views\Home\Index.cshtml"
WriteAttributeValue("", 3651, Url.Action("Ir", "AudioVisual"), 3651, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3683, "\'", 3683, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Ir</button>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
