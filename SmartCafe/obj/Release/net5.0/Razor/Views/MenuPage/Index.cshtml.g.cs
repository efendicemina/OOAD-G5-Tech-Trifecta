#pragma checksum "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56730b337906202c9a237d00d68a80e400e465ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuPage_Index), @"mvc.1.0.view", @"/Views/MenuPage/Index.cshtml")]
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
#line 1 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\_ViewImports.cshtml"
using SmartCafe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
using SmartCafe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56730b337906202c9a237d00d68a80e400e465ba", @"/Views/MenuPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"568aa064e73d545947419b6277d88513bebeabe2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MenuPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartCafe.Models.Drink>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/lagoonLogoWhiteTransparent.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
  
    ViewData["Title"] = "Menu Page";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56730b337906202c9a237d00d68a80e400e465ba6967", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Lagoon's Cocktail Bar</title>
    <style>
        body {
            font-family: Montserrat sans-serif;
            margin: 50;
            padding: 0;
            background-image: url('/images/abstractBackground1.png');
            color: white;
        }

        .header {
            background-color: transparent;
            color: #fff;
            padding: 0px 10px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .nav {
            list-style-type: none;
            display: flex;
            align-items: center;
        }

            .nav li {
                margin-right: 35px;
                margin-top: -50px;
                text-transform: uppercase;
                font-size: 14px;
            }

            .nav a {
                color: #fff;
                text-decoration: none;
                padding-bottom:");
                WriteLiteral(@" 3px;
                border-bottom: 2px solid transparent;
                transition: border-bottom-color 0.3s;
            }

                .nav a:hover {
                    border-bottom-color: #fff;
                }

        .logo img {
            max-width: 35%;
            margin-right: 0px;
            margin-left: 15px;
            margin-top: -20px;
        }

        .buttons-container {
            display: flex;
            gap: 10px;
            margin-top: 20px;
        }

        .carousel {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            gap: 20px;
            margin-top: 50px;
        }

        .carousel-item {
            position: relative;
            text-align: center;
        }

            .carousel-item img {
                position: relative;
                width: 200px;
                height: 200px;
                object-fit: cover;
            }

        .carousel-item {
 ");
                WriteLiteral(@"           position: relative;
            text-align: center;
        }

            .carousel-item .image-container {
                position: relative;
                display: inline-block;
            }

        .info-icon {
            position: absolute;
            top: 10px;
            left: 10px;
            font-size: 24px;
            color: white;
            cursor: pointer;
            z-index: 1;
            opacity: 1;
            transition: opacity 0.3s;
        }

        .info-message {
            position: absolute;
            top: -100%;
            left: 50%;
            transform: translate(-50%, -50%);
            padding: 10px;
            background-color: rgba(0, 0, 0, 0.8);
            color: white;
            font-size: 14px;
            font-weight: bold;
            opacity: 0;
            pointer-events: none;
            transition: opacity 0.3s;
        }

        .carousel-image:hover .info-icon + .info-message {
            top: 5");
                WriteLiteral(@"0%;
            opacity: 1;
        }


        .quantity {
            display: flex;
            align-items: center;
            justify-content: center;
            margin-top: 10px;
        }

            .quantity button {
                width: 30px;
                height: 30px;
                background-color: #fff;
                border: none;
                color: #000;
                font-size: 16px;
                cursor: pointer;
                outline: none;
            }

            .quantity input {
                width: 40px;
                height: 30px;
                text-align: center;
                font-size: 16px;
                border: none;
                outline: none;
            }

        .finish-order {
            display: flex;
            justify-content: center;
            margin-top: 20px;
        }

            .finish-order button {
                padding: 10px 20px;
                background-color: #ff3366;
       ");
                WriteLiteral(@"         color: #fff;
                border: none;
                border-radius: 5px;
                font-size: 16px;
                cursor: pointer;
                transition: background-color 0.3s;
                margin-bottom: 20px;
            }

                .finish-order button:hover {
                    background-color: #e6004c;
                }
    </style>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56730b337906202c9a237d00d68a80e400e465ba12682", async() => {
                WriteLiteral("\r\n    <div class=\"header\">\r\n        <div class=\"logo\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56730b337906202c9a237d00d68a80e400e465ba13015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n        <ul class=\"nav\">\r\n            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56730b337906202c9a237d00d68a80e400e465ba14258", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56730b337906202c9a237d00d68a80e400e465ba16006", async() => {
                    WriteLiteral("About Us");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56730b337906202c9a237d00d68a80e400e465ba17671", async() => {
                    WriteLiteral("Contact");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56730b337906202c9a237d00d68a80e400e465ba19335", async() => {
                    WriteLiteral("Staff Login");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n\r\n    <h1 style=\"text-align:center\">The Menu</h1>\r\n\r\n    <!-- kod za menu -->\r\n    <div class=\"carousel\">\r\n");
#nullable restore
#line 203 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
         if (ViewBag.Drinks != null)
        {
            var drinks = ViewBag.Drinks as IEnumerable<SmartCafe.Models.Drink>;
            foreach (var drink in drinks)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"carousel-item\">\r\n                    <div class=\"image-container\">\r\n                        <i class=\"fas fa-info-circle info-icon\"></i>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 5886, "\"", 5939, 1);
#nullable restore
#line 211 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
WriteAttributeValue("", 5892, Url.Content("~/images/" + drink.name + ".jpg"), 5892, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 5940, "\"", 5957, 1);
#nullable restore
#line 211 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
WriteAttributeValue("", 5946, drink.name, 5946, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"carousel-image\" />\r\n                    </div>\r\n                    <div class=\"info-message\">Default message about ingredients</div>\r\n                    <h3>");
#nullable restore
#line 214 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                   Write(drink.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <p>Price: ");
#nullable restore
#line 215 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                         Write(drink.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <div class=\"quantity\">\r\n                        <button class=\"minus-btn\" data-drink-id=\"");
#nullable restore
#line 217 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                                                            Write(drink.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">-</button>\r\n                        <input type=\"text\" class=\"quantity-input\" value=\"0\" />\r\n                        <button class=\"plus-btn\" data-drink-id=\"");
#nullable restore
#line 219 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                                                           Write(drink.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">+</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 222 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
#nullable restore
#line 226 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
      
        var tableNumber = ViewBag.TableNumber;
        var selectedDrinks = ViewBag.SelectedDrinks as List<Tuple<string, int, double>>;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- Finish Order button -->\r\n    <div class=\"finish-order\">\r\n        <button id=\"finish-order-btn\" type=\"button\" onclick=\"submitOrder()\">Finish Order</button>\r\n        <!-- Table Number label -->\r\n        <p>Selected Table Number: ");
#nullable restore
#line 235 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                             Write(ViewBag.SelectedTableNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

    </div>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            const quantityElements = document.querySelectorAll('.quantity');

            quantityElements.forEach(function (element) {
                const minusBtn = element.querySelector('.minus-btn');
                const plusBtn = element.querySelector('.plus-btn');
                const quantityInput = element.querySelector('input.quantity-input');

                minusBtn.addEventListener('click', function () {
                    updateQuantity(-1);
                });

                plusBtn.addEventListener('click', function () {
                    updateQuantity(1);
                });

                function updateQuantity(change) {
                    let quantity = parseInt(quantityInput.value);
                    quantity += change;

                    if (quantity < 0) {
                        quantity = 0;
                    }

                    quantity");
                WriteLiteral(@"Input.value = quantity;
                }
            });

            const finishOrderButton = document.getElementById('finish-order-btn');
            finishOrderButton.addEventListener('click', function () {
                const selectedDrinks = [];
                const quantityInputs = document.querySelectorAll('.quantity-input');


                quantityInputs.forEach(function (input) {
                    const quantity = parseInt(input.value);
                    const drinkId = input.parentElement.querySelector('.minus-btn').getAttribute('data-drink-id');
                    if (quantity > 0) {
                        selectedDrinks.push({ drinkId: drinkId, quantity: quantity });
                    }
                });

                // Create a form and append selectedDrinks as hidden inputs
                const form = document.createElement('form');
                form.method = 'POST';
                form.action = '/ModifyOrder/Index?tableNumber=");
#nullable restore
#line 285 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                                                         Write(ViewBag.SelectedTableNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';  // Dodavanje tableNumber u rutu

                // Create a hidden input field for the selected table number
                const tableNumberInput = document.createElement('input');
                tableNumberInput.type = 'hidden';
                tableNumberInput.name = 'tableNumber';
                tableNumberInput.value = '");
#nullable restore
#line 291 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                                     Write(ViewBag.SelectedTableNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                form.appendChild(tableNumberInput);

                selectedDrinks.forEach(function (drink) {
                    const drinkIdInput = document.createElement('input');
                    drinkIdInput.type = 'hidden';
                    drinkIdInput.name = 'selectedDrinks[' + drink.drinkId + ']';
                    drinkIdInput.value = drink.quantity;
                    form.appendChild(drinkIdInput);
                });

                // Append the form to the document and submit it
                document.body.appendChild(form);
                form.submit();
            });

            function getDrinkNameById(drinkId) {
                const drinks = ");
#nullable restore
#line 308 "C:\Users\User-PC\Desktop\OOAD-G3-Tech-Trifecta\SmartCafe\Views\MenuPage\Index.cshtml"
                          Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                const drink = drinks.find(d => d.id === drinkId);
                return drink ? drink.name : 'Nepoznato';
            }
        });
    </script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartCafe.Models.Drink>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
