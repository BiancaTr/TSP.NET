#pragma checksum "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58e900ebb2b8797787c55d0abf57383f5a57a7f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyPhotosASP.Pages.Pages_Details), @"mvc.1.0.razor-page", @"/Pages/Details.cshtml")]
namespace MyPhotosASP.Pages
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
#line 1 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\_ViewImports.cshtml"
using MyPhotosASP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e900ebb2b8797787c55d0abf57383f5a57a7f6", @"/Pages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3e161441ab58dc109ab3ef83d8c711de8b256f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:bisque;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58e900ebb2b8797787c55d0abf57383f5a57a7f63434", async() => {
                WriteLiteral("\r\n\r\n        <h3>");
#nullable restore
#line 9 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
       Write(ViewData["POST"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n        <h5>");
#nullable restore
#line 11 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
       Write(Model.picture.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        <h5>");
#nullable restore
#line 12 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
       Write(Model.picture.Place);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        <h5>");
#nullable restore
#line 13 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
       Write(Model.picture.Person);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        <h5>");
#nullable restore
#line 14 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
       Write(Model.picture.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n        <h5>");
#nullable restore
#line 15 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
       Write(Model.picture.Event);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
          


            var image = String.Format("data:image/gif;base64,{0}",
                  Convert.ToBase64String(System.IO.File.ReadAllBytes(Model.picture.Path)));

        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <img");
                BeginWriteAttribute("src", " src=\"", 583, "\"", 595, 1);
#nullable restore
#line 26 "C:\Users\Bobibi\source\repos\MyPhotos2\MyPhotosASP\Pages\Details.cshtml"
WriteAttributeValue("", 589, image, 589, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyPhotosASP.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPhotosASP.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyPhotosASP.DetailsModel>)PageContext?.ViewData;
        public MyPhotosASP.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591