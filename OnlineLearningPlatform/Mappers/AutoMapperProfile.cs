using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;

namespace OnlineLearningPlatform.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // ==========================================================
            // Mappings for FAQ (đã có)
            // ==========================================================
            CreateMap<FAQ, FAQsViewModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.FaqId));

            CreateMap<FAQsViewModel, FAQ>()
                .ForMember(dest => dest.FaqId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.CommonStatus, opt => opt.Ignore());

            // ==========================================================
            // Mapping for Course List (Course -> CourseViewModel - đã có)
            // ==========================================================
            CreateMap<Course, CourseViewModel>()
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.Description))
                .ForMember(d => d.ImageUrl, opt => opt.MapFrom(s =>
                    (s.CourseImageUrls != null && s.CourseImageUrls.Any()) ? s.CourseImageUrls.First().Url : null))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.Status.ToString()))
                .ForMember(d => d.MentorId, opt => opt.MapFrom(s =>
                    s.Creator != null ? s.Creator : (s.CreatorUser != null ? s.CreatorUser.Id : null)))
                .ForMember(d => d.MentorName, opt => opt.MapFrom(s => s.CreatorUser != null ? s.CreatorUser.FullName : null))
                .ForMember(d => d.MentorAvatarUrl, opt => opt.MapFrom(s => s.CreatorUser != null ? s.CreatorUser.AvatarUrl : null))
                .ForMember(d => d.LevelName, opt => opt.MapFrom(s => s.Level != null ? s.Level.LevelName : null))
                .ForMember(d => d.CategoryNames, opt => opt.MapFrom(s =>
                    s.CourseCategories != null ? s.CourseCategories.Select(cc => cc.Category.CategoryName).ToList() : new List<string>()))
                .ForMember(d => d.StudyTime, opt => opt.MapFrom(s => s.StudyTime));



            CreateMap<Course, CourseDetailsViewModel>()
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src =>
                    (src.CourseImageUrls != null && src.CourseImageUrls.Any()) ? src.CourseImageUrls.First().Url : null))
                .ForMember(dest => dest.MentorId, opt => opt.MapFrom(src => src.Creator))
                .ForMember(dest => dest.MentorName, opt => opt.MapFrom(src =>
                    src.CreatorUser != null ? src.CreatorUser.FullName : null))
                .ForMember(dest => dest.MentorAvatarUrl, opt => opt.MapFrom(src =>
                    src.CreatorUser != null ? src.CreatorUser.AvatarUrl : null))
                .ForMember(dest => dest.LevelName, opt => opt.MapFrom(src =>
                    src.Level != null ? src.Level.LevelName : null))
                .ForMember(dest => dest.CategoryNames, opt => opt.MapFrom(src =>
                    src.CourseCategories != null ? src.CourseCategories.Select(cc => cc.Category.CategoryName).ToList() : new List<string>()))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

            CreateMap<Module, ModuleViewModel>();
            CreateMap<Lesson, LessonViewModel>();
            CreateMap<Quiz, QuizViewModel>();
            CreateMap<Question, QuestionViewModel>();

            CreateMap<Ratings, RatingViewModel>()
     .ForMember(dest => dest.UserName, opt => opt.MapFrom(src =>
         src.User != null ? src.User.FullName : "Anonymous"))
     .ForMember(dest => dest.UserAvatarUrl, opt => opt.MapFrom(src =>
         src.User != null ? src.User.AvatarUrl : null)) // <-- Thêm dòng này
     .ForMember(dest => dest.RatingValue, opt => opt.MapFrom(src =>
         src.Rating))
     .ForMember(dest => dest.Feedback, opt => opt.MapFrom(src =>
         src.Feedback))
     .ForMember(dest => dest.FeedbackDate, opt => opt.MapFrom(src =>
         src.DateCreated));
            CreateMap<ModuleInputViewModel, Module>();
            CreateMap<Module, ModuleInputViewModel>();
            CreateMap<LessonInputViewModel, Lesson>();
            CreateMap<Lesson, LessonInputViewModel>();
            CreateMap<Course, CourseHierarchyViewModel>();
            CreateMap<Module, ModuleHierarchyViewModel>();
            CreateMap<Lesson, LessonHierarchyViewModel>();
            CreateMap<Quiz, QuizHierarchyViewModel>();
        }
    }
}