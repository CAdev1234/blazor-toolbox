#pragma checksum "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d02999af1d72e9283a5dfa9b90e69368d2082f40"
// <auto-generated/>
#pragma warning disable 1591
namespace Blz.FormBuilder.Pages.auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
using Blz.FormBuilder.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-top: 15vh;");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex justify-content-center h-100");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, @"<div class=""card-header"">
                    <h3>Sign Up</h3>
                    <div class=""d-flex justify-content-end social_icon"">
                        <span><i class=""fab fa-facebook-square"" style=""font-size:50px""></i></span>
                        <span><i class=""fab fa-google-plus-square"" style=""font-size:50px""></i></span>
                        <span><i class=""fab fa-twitter-square"" style=""font-size:50px""></i></span>
                    </div>
                </div>
                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "input-group form-group");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.AddMarkupContent(19, "<div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\"><i class=\"fas fa-user\"></i></span>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Username");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
                                                                                                     userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "input-group form-group");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.AddMarkupContent(31, "<div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\"><i class=\"fas fa-envelope\"></i></span>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", "Email");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
                                                                                                  userEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userEmail = __value, userEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-group form-group");
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.AddMarkupContent(43, "<div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\"><i class=\"fas fa-key\"></i></span>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "password");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "placeholder", "Password");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
                                                                                                         userPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userPassword = __value, userPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "input-group form-group");
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.AddMarkupContent(55, "<div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\"><i class=\"fas fa-key\"></i></span>\r\n                        </div>\r\n                        ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "password");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "placeholder", "Confirm Password");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
                                                                                                                 confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.AddMarkupContent(64, "<div class=\"row align-items-center remember\">\r\n                        <input type=\"checkbox\">Remember Me\r\n                    </div>\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "form-group");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "submit");
            __builder.AddAttribute(70, "value", "Sign Up");
            __builder.AddAttribute(71, "class", "btn signup_btn float-right");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
                                                                                                           async()=>await RegisterSubmit()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.AddMarkupContent(76, "<div class=\"card-footer\">\r\n                    <div class=\"d-flex justify-content-center links\">\r\n                        Already have an account?<a href=\"/\">Sign In</a>\r\n                    </div>\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.AddMarkupContent(81, "<style>\r\n    .container {\r\n        height: 100%;\r\n        align-content: center;\r\n    }\r\n\r\n    .card {\r\n        padding-top: 20px;\r\n        padding-bottom: 20px;\r\n        margin-top: auto;\r\n        margin-bottom: auto;\r\n        width: 400px;\r\n        background-color: rgba(0,0,0,0.5) !important;\r\n    }\r\n\r\n    .social_icon span {\r\n        font-size: 60px;\r\n        margin-left: 10px;\r\n        color: #FFC312;\r\n    }\r\n\r\n        .social_icon span:hover {\r\n            color: white;\r\n            cursor: pointer;\r\n        }\r\n\r\n    .card-header h3 {\r\n        color: white;\r\n    }\r\n\r\n    .social_icon {\r\n        position: absolute;\r\n        right: 20px;\r\n        top: -45px;\r\n    }\r\n\r\n    .input-group-prepend span {\r\n        width: 50px;\r\n        background-color: #FFC312;\r\n        color: black;\r\n        border: 0 !important;\r\n    }\r\n\r\n    input:focus {\r\n        outline: 0 0 0 0 !important;\r\n        box-shadow: 0 0 0 0 !important;\r\n    }\r\n\r\n    .remember {\r\n        color: white;\r\n    }\r\n\r\n        .remember input {\r\n            width: 20px;\r\n            height: 20px;\r\n            margin-left: 15px;\r\n            margin-right: 5px;\r\n        }\r\n\r\n    .signup_btn {\r\n        color: black;\r\n        background-color: #FFC312;\r\n        width: 100px;\r\n    }\r\n\r\n        .signup_btn:hover {\r\n            color: black;\r\n            background-color: white;\r\n        }\r\n\r\n    .links {\r\n        color: white;\r\n    }\r\n\r\n        .links a {\r\n            margin-left: 4px;\r\n            color: #FFC312;\r\n        }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 145 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\auth\Register.razor"
       
    User registerUser = new User();
    string userName { get; set; }
    string userEmail { get; set; }
    string userPassword { get; set; }
    string confirmPassword { get; set; }
    string userIpAddress { get; set; }
    byte[] salt { get; set; }

    Microsoft.AspNetCore.Http.HttpContextAccessor contextAccessor = new Microsoft.AspNetCore.Http.HttpContextAccessor();

    async Task RegisterSubmit()
    {
        try
        {

            if(userPassword == confirmPassword)
            {
                registerUser.UserName = userName;
                registerUser.UserEmail = userEmail;
                salt = CreateSalt();
                registerUser.UserSalt = Convert.ToBase64String(salt);
                registerUser.UserSaltPassword = CreateSaltedPassword(salt);
                registerUser.EmailLinkVerificationCode = "";
                //registerUser.EmailLinkVerificationCodeValidUntil = DateTime.Now;
                registerUser.IsRegisterationConfirmationEmailSent = false;
                //registerUser.VerifiedAgainstEmailVerificationRecordId = "";
                //registerUser.IsSuccessfulVerification = false;
                //registerUser.LinkUrlAttemped = "";
                //registerUser.IsNewPasswordCreated = false;
                //registerUser.NewPasswordCreatedSalt = "";
                userIpAddress = contextAccessor.HttpContext.Connection?.RemoteIpAddress.ToString();
                registerUser.UserIpAddress = userIpAddress;
                registerUser.UserCreateTime = DateTime.Now;
                //registerUser.TokenValidTime = DateTime.Now;
                //registerUser.LoginTypeId = 1;
                registerUser.RegisterTypeId = 1;
                registerUser.IsUserLoggedOnAtLeastOnce = false;
                //registerUser.IsEmailAddressBeenVerifiedByUser = false;
                //registerUser.IsSuccess = false;
                //registerUser.IsError = false;
                //registerUser.ErrorAnalysis = "";
                //registerUser.ErrorDescription = "";
                //Console.WriteLine(userIpAddress);
                await DAL.CreateUser(registerUser);
                NavigationManager.NavigateTo("/email/verification");
            }
            else
            {
                return;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
    public byte[] CreateSalt()
    {
        byte[] salt = new byte[128 / 8];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }
        return salt;
    }
    public string CreateSaltedPassword(byte[] salt)
    {
        string salt_str = Convert.ToBase64String(salt);
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: userPassword,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256/8)
        );
        return hashed;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DAL DAL { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
