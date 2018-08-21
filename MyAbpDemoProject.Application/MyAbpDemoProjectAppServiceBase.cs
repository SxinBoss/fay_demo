using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using MyAbpDemoProject.Authorization.Users;
using MyAbpDemoProject.MultiTenancy;
using MyAbpDemoProject.Users;
using Microsoft.AspNet.Identity;

namespace MyAbpDemoProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyAbpDemoProjectAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected MyAbpDemoProjectAppServiceBase()
        {
            LocalizationSourceName = MyAbpDemoProjectConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}