#pragma checksum "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847f7360d7950aeb9aa0cd0e31750396597f68ba"
// <auto-generated/>
#pragma warning disable 1591
namespace Blz.FormBuilder.Pages
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
#line 4 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
using Blz.FormBuilder.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
using Blz.FormBuilder.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
using System.Security.Cryptography;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmailVerifyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/profile")]
    public partial class UserProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "user-profile");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-4");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "font-size:50px; font-weight:bold");
            __builder.AddContent(11, 
#nullable restore
#line 17 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                           currentUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        <div class=\"col-4\"></div>\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-4");
            __builder.AddAttribute(16, "style", "text-align: right; padding-top:10px");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-secondary");
            __builder.AddAttribute(20, "style", "width:150px;height:40px;");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                () => GoToHome()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n                Go to Home\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "<br>\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<label class col-form-label\">Email:</label>\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "disabled", true);
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                              currentUser.UserEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentUser.UserEmail = __value, currentUser.UserEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    <br>\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<label class col-form-label\">RegisterType:</label>\r\n        ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "text");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "disabled", true);
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                              registerType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => registerType = __value, registerType));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    <hr style=\"width: 100%\">\r\n    ");
            __builder.AddMarkupContent(50, "<div class=\"row\">\r\n        <div>You can login again using following buttons</div>\r\n    </div><br>\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "d-flex justify-content-start social_icon");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-secondary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                      (() => GoToUserLogin())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "\r\n                <i class=\"fas fa-envelope-open\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-secondary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                      (() => GoToFBLogin())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "\r\n                <i class=\"fab fa-facebook-f\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "btn btn-secondary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                        ()=> GoToGoogleLogin()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                <i class=\"fab fa-google\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-secondary");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                        ()=> GoToTwitterLogin()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(79, "\r\n                <i class=\"fab fa-twitter\"></i>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    <hr style=\"width: 100%\">\r\n    ");
            __builder.AddMarkupContent(83, "<div class=\"row\">\r\n        <div>You can change password using following button</div>\r\n    </div><br>\r\n    ");
            __builder.AddMarkupContent(84, "<div class=\"row\">\r\n        <button type=\"button\" class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#changePasswordModal\">Change password</button>\r\n    </div>\r\n    \r\n    ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "modal fade");
            __builder.AddAttribute(87, "id", "changePasswordModal");
            __builder.AddAttribute(88, "tabindex", "-1");
            __builder.AddAttribute(89, "aria-labelledby", "changePasswordModalLabel");
            __builder.AddAttribute(90, "aria-hidden", "true");
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "modal-dialog");
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "modal-content");
            __builder.AddMarkupContent(97, "\r\n                ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "modal-header");
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.OpenElement(101, "h5");
            __builder.AddAttribute(102, "class", "modal-title");
            __builder.AddAttribute(103, "id", "changePasswordModalLabel");
            __builder.AddContent(104, 
#nullable restore
#line 69 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                           currentUser.UserEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.AddMarkupContent(106, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "modal-body");
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "form");
            __builder.AddMarkupContent(112, "\r\n                        ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "form-group");
            __builder.AddMarkupContent(115, "\r\n                            ");
            __builder.AddMarkupContent(116, "<label class=\"col-form-label\">New Password:</label>\r\n                            ");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "password");
            __builder.AddAttribute(119, "class", "form-control");
            __builder.AddAttribute(120, "id", "new-password");
            __builder.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                                                        newPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPassword = __value, newPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "form-group");
            __builder.AddMarkupContent(127, "\r\n                            ");
            __builder.AddMarkupContent(128, "<label class=\"col-form-label\">Confirm Password:</label>\r\n                            ");
            __builder.OpenElement(129, "input");
            __builder.AddAttribute(130, "type", "password");
            __builder.AddAttribute(131, "class", "form-control");
            __builder.AddAttribute(132, "id", "confirm-password");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                                                            confirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPassword = __value, confirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "modal-footer");
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.AddMarkupContent(142, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                    ");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "type", "button");
            __builder.AddAttribute(145, "class", "btn btn-primary");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
                                                                              ()=>ChangePassword()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(147, "Change Password");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
            __builder.AddMarkupContent(154, @"<style>
    .user-profile {
        padding-top: 30px;
        padding-bottom: 30px;
        padding-left: 30%;
        padding-right: 30%;
        background: ghostwhite;
    }

    .social_icon button {
        margin-left: 5px;
        margin-right: 5px;
        width: 50px;
        height: 50px;
        display: flex;
        justify-content: center;
        align-items: center;
    }

        .social_icon button i {
            font-size: 30px;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
       
    public User currentUser;
    public string registerType { get; set; }
    public string newPassword { get; set; }
    public string confirmPassword { get; set; }

    protected override async Task OnInitializedAsync()
    {
        currentUser = new User();
        currentUser = await SessionStorage.GetItemAsync<User>("createdUser");
        if (currentUser.RegisterTypeId == 1)
        {
            registerType = "Register with User Email";
        }
    }

    public async Task ChangePassword()
    {
        if (newPassword == confirmPassword)
        {
            Console.WriteLine("change password modal");
            User user = new User();
            user.UserSalt = CreateSalt();
            user.UserSaltPassword = newPassword + user.UserSalt;
            user.UserEmail = currentUser.UserEmail;
            await DAL.ChangePassword(user);
            // Send changed password to user by email
            MailService mailService = new MailService();
            mailService.SendMailWithSMTP(user.UserEmail, "Changed Password", newPassword);
        }
        await JSRuntime.InvokeVoidAsync("CloseChangePasswordModal");

    }
    public string CreateSalt()
    {
        byte[] salt = new byte[128 / 8];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }
        return Convert.ToBase64String(salt);
    }
    public void GoToHome()
    {
        navigationManager.NavigateTo("/home");
    }
    public void GoToUserLogin()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
        navigationManager.NavigateTo("/");
    }
    public void GoToFBLogin()
    {

    }
    public void GoToGoogleLogin()
    {

    }
    public void GoToTwitterLogin()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DAL DAL { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService SessionStorage { get; set; }
    }
}
#pragma warning restore 1591
