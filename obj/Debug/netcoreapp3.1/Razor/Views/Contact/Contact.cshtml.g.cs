#pragma checksum "C:\Users\luca_\source\repos\Dierenasiel\DierenasielTongelre\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37a703e64816480b5c05ad1a3998f49b5a63620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contact), @"mvc.1.0.view", @"/Views/Contact/Contact.cshtml")]
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
#line 1 "C:\Users\luca_\source\repos\Dierenasiel\DierenasielTongelre\Views\_ViewImports.cshtml"
using DierenasielTongelre;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luca_\source\repos\Dierenasiel\DierenasielTongelre\Views\_ViewImports.cshtml"
using DierenasielTongelre.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luca_\source\repos\Dierenasiel\DierenasielTongelre\Views\_ViewImports.cshtml"
using DierenasielTongelre.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c37a703e64816480b5c05ad1a3998f49b5a63620", @"/Views/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3291330b8505da8e221622ee8eb7e740a9c5c252", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/SleepyGoldenRetriever.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sleepy golden retriever"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("322"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\luca_\source\repos\Dierenasiel\DierenasielTongelre\Views\Contact\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h1>Contact</h1>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <br />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c37a703e64816480b5c05ad1a3998f49b5a636205170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-6"">
            <h6>Voor vragen kunt u ook een bericht sturen!</h6>
            <div class=""form-group"">
                <label class=""control-label"" for=""name"">Uw naam:</label>
                <input placeholder=""Voornaam en achternaam..."" class=""form-control"" type=""text"" id=""name"" name=""name""");
            BeginWriteAttribute("value", " value=\"", 655, "\"", 663, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"email\">Email:</label>\r\n                <input placeholder=\"Emailadres...\" class=\"form-control\" type=\"text\" id=\"emailaddress\" name=\"emailaddress\"");
            BeginWriteAttribute("value", " value=\"", 919, "\"", 927, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label for=""question"">Stel hieronder uw vraag:</label>
                <textarea class=""form-control"" input placeholder=""Type uw vraag..."" id=""question"" rows=""3""></textarea>
            </div>
            <div class=""form-group"">
                <button type=""button"" class=""btn btn-primary"">Verstuur!</button>
            </div>
        </div>
    </div>
    <div>
        <br />
    </div>
    <div class=""row"">
        <div class=""col-8"">
            <iframe frameborder=""1"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" width=""700"" height=""440""
                    src=""https://maps.google.com/maps?hl=nl&q=insulindelaan130&ie=UTF8&t=m&z=15&iwloc=B&output=embed"">
            </iframe>
        </div>
        <div class=""col-4"">
            <div class=""row"">
                <h4>Contactgegevens</h4>
            </div>
            <div class=""row"">
                <p> Telefoon: 043-3647926</p>
            </div>
   ");
            WriteLiteral(@"         <div class=""row"">
                <p> E-mail: dierenasieltongelre@gmail.com</p>
            </div>
            <div class=""row"">
                <p> U kunt ook een bezoekje brengen op het onderstaande addres: </p>
            </div>
            <div class=""row"">
                <p>	<i>Insulindelaan 130 Tongelre, Eindhoven</i></p>
            </div>
        </div>
    </div>

</div>");
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
