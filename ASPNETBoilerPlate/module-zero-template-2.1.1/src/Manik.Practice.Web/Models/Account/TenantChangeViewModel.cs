using Abp.AutoMapper;
using Manik.Practice.Sessions.Dto;

namespace Manik.Practice.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}