using AutoMapper;
using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;

namespace RM.Core.Service.Adapters
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WebUser, BizUser>();
            CreateMap<BizUser, WebUser>();
        }
    }
}