#pragma checksum "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "446d500c01b889e53fac60a9ae2a4db3117c2209"
// <auto-generated/>
#pragma warning disable 1591
namespace DogCatWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using DogCatWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\_Imports.razor"
using DogCatWebApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>DogCat Viewer</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<p>
    This is a demonstration of a game where you count up between a user-defined set of bounds. 
    If the number is divisible by 2, the number is replaced with the word ""dog"". If it's divisible by 
    7, the word cat. If it's divisible by both, then it's replaced with ""dogcat"".
</p>

");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "<label for=\"lower-bound\">Lower Bound: </label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "id", "lower-bound");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
                                   lowerBound

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lowerBound = __value, lowerBound));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "<label for=\"upper-bound\">Upper Bound: </label>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "id", "upper-bound");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
                                   upperBound

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => upperBound = __value, upperBound));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
                                          PlayDogCat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Submit Bounds");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
 if (numberList != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "ul");
#nullable restore
#line 24 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
         foreach (string item in numberList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "li");
            __builder.AddContent(22, 
#nullable restore
#line 26 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
                 item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\csema\Documents\DogCatBlazor\DogCatBlazor\DogCatWebApp\DogCatWebApp\Pages\Index.razor"
       
    private int lowerBound = 1;
    private int upperBound = 100;

    private string[] numberList;

    private void PlayDogCat()
    {
        //set the size of the list based on input bounds
        numberList = new string[upperBound - lowerBound + 1];
        //words to be used
        string firstWord = "dog";
        string secondWord = "cat";
        //multiples to be replaced with words
        int firstNumber = 2;
        int secondNumber = 7;

        //build list
        for (int i = 0; i < numberList.Length; i++)
        {
            string message = "";

            //check divisibility
            if ((i + lowerBound) % firstNumber == 0)
            {
                message += firstWord;
            }
            if ((i + lowerBound) % secondNumber == 0)
            {
                message += secondWord;
            }

            //add appropriate string
            if (message.Equals(""))
            {
                numberList[i] = "" + (i+lowerBound);
            }
            else
            {
                numberList[i] = message;
            }

        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
