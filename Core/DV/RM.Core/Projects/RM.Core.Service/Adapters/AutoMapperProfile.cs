using AutoMapper;
using RM.Core.Business.Entities.Views;
using RM.Core.Web.Entities.Views;

namespace RM.Core.Service.Adapters
{
    /// <summary>
    /// Class AutoMapperProfile.
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
        /// </summary>
        public AutoMapperProfile()
        {
            CreateMap<WebUser, BizUser>();
            CreateMap<BizUser, WebUser>();
        }
    }
}