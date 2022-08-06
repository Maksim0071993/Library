using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Library.Models;
using Library.BusinessLogicLayer.Interfaces;
using AutoMapper;
using Library.BusinessLogicLayer.Models;

namespace Library.Account
{
    public partial class Register : Page
    {
        public IUserProfileService UserProfileService { get; set; }
        private readonly IMapper _mapper;
        public Register(IUserProfileService userProfileService)
        {
            UserProfileService = userProfileService;
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile.MappingProfile>());
            _mapper = new Mapper(configuration);
        }
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            //UserProfileViewModel userModel = new UserProfileViewModel();
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                //userModel.Email = Email.Text;
                //userModel.UserPassword = Password.Text;
                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                //UserProfileService.AddUser(_mapper.Map<UserProfileModel>(userModel));
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}