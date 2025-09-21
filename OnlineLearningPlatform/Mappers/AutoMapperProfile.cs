using AutoMapper;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OnlineLearningPlatform.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FAQ, FAQsViewModel>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.FaqId));

            CreateMap<FAQsViewModel, FAQ>()
                .ForMember(dest => dest.FaqId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CommonStatus, opt => opt.Ignore());
        }
    }
}
