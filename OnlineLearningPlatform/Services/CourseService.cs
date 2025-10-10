using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Course>> GetCoursesForMentorAsync(string mentorId)
        {
            return await _courseRepository.GetAllByMentorIdAsync(mentorId);
        }

        public async Task<Course?> GetCourseByIdAndMentorAsync(long courseId, string mentorId)
        {
            return await _courseRepository.GetByIdAndMentorIdAsync(courseId, mentorId);
        }

        public async Task<Course> CreateCourseAsync(Course course, string mentorId)
        {
            course.MentorId = mentorId;
            course.CreatedAt = DateTime.Now;
            course.Status = Enums.CourseStatus.Draft; // Draft
            return await _courseRepository.AddAsync(course);
        }

        public async Task<bool> UpdateCourseAsync(Course course, string mentorId)
        {
            var existingCourse = await _courseRepository.GetByIdAndMentorIdAsync(course.CourseId, mentorId);
            if (existingCourse == null)
            {
                return false;
            }


            existingCourse.CourseName = course.CourseName;
            existingCourse.Description = course.Description;
            existingCourse.Price = course.Price;
            existingCourse.Discount = course.Discount;
            existingCourse.StudyTime = course.StudyTime;
            existingCourse.LevelId = course.LevelId;
            existingCourse.UpdatedAt = DateTime.Now;

            await _courseRepository.UpdateAsync(existingCourse);
            return true;
        }

        public async Task<bool> DeleteCourseAsync(long courseId, string mentorId)
        {
            var courseToDelete = await _courseRepository.GetByIdAndMentorIdAsync(courseId, mentorId);
            if (courseToDelete == null)
            {
                return false;
            }

            courseToDelete.DeletedAt = DateTime.Now;
            await _courseRepository.UpdateAsync(courseToDelete);
            //  await _courseRepository.Delete(courseToDelete)

            return true;
        }
    }
}
