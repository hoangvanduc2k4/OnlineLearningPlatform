using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlarform.Models.Entities;
using OnlineLearningPlarform.Models.Entities.Others;
using OnlineLearningPlarform.Models.Entities.UserPart;
using OnlineLearningPlarform.Models.Entities.CoursePart; // Assuming this namespace for course-related entities

namespace OnlineLearningPlarform.Data
{
    public class OnlineLearningDBContext : IdentityDbContext<User>
    {
        public OnlineLearningDBContext(DbContextOptions<OnlineLearningDBContext> options)
            : base(options)
        {
        }

        public DbSet<AnswerQuiz> AnswerQuizzes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<CourseImageUrl> CourseImageUrls { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizResult> QuizResults { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<AdminReviewCourse> AdminReviewCourses { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }

        public DbSet<MentorApplication> MentorApplications { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>(b =>
            {
                b.ToTable("Users");
                b.HasMany(u => u.MentorApplications)
                 .WithOne(a => a.User)
                 .HasForeignKey(a => a.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasMany(u => u.ReviewedApplications)
                 .WithOne(a => a.AdminReviewer)
                 .HasForeignKey(a => a.AdminReviewerId)
                 .OnDelete(DeleteBehavior.SetNull);
                b.HasMany(u => u.CreatedCourses)
                 .WithOne(c => c.CreatorUser)
                 .HasForeignKey(c => c.MentorId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasMany(u => u.AcceptedCourses)
                 .WithOne(c => c.AcceptorUser)
                 .HasForeignKey(c => c.AdminId)
                 .OnDelete(DeleteBehavior.SetNull);
            });
            builder.Entity<MentorApplication>(b =>
            {
                b.Property(a => a.Status)
                 .HasConversion<int>();
            });
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            // Enum Conversions
            builder.Entity<Course>(b =>
            {
                b.Property(c => c.Status)
                 .HasConversion<int>();
            });
            builder.Entity<Lesson>(b =>
            {
                b.Property(l => l.Status)
                 .HasConversion<int>();
            });
            builder.Entity<Module>(b =>
            {
                b.Property(m => m.Status)
                 .HasConversion<int>();
            });
            builder.Entity<Option>(b =>
            {
                b.Property(o => o.Status)
                 .HasConversion<int>();
            });
            builder.Entity<AdminReviewCourse>(b =>
            {
                b.Property(a => a.Status)
                 .HasConversion<int>();
            });
            builder.Entity<TransactionHistory>(b =>
            {
                b.Property(t => t.Status)
                 .HasConversion<int>();
            });
            builder.Entity<FAQ>(b =>
            {
                b.Property(f => f.CommonStatus)
                 .HasConversion<int>();
            });

            // Composite Keys
            builder.Entity<CourseCategory>(b =>
            {
                b.HasKey(cc => new { cc.CategoryId, cc.CourseId });
            });
            builder.Entity<CourseEnrollment>(b =>
            {
                b.HasKey(ce => new { ce.CourseId, ce.UserId });
            });
            builder.Entity<WishList>(b =>
            {
                b.HasKey(w => new { w.CourseId, w.UserId });
            });

            // Relationships and Delete Behaviors
            builder.Entity<AnswerQuiz>(b =>
            {
                b.HasOne(a => a.User)
                 .WithMany()
                 .HasForeignKey(a => a.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(a => a.Question)
                 .WithMany()
                 .HasForeignKey(a => a.QuestionId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Category>(b =>
            {
                b.HasMany(c => c.CourseCategories)
                 .WithOne(cc => cc.Category)
                 .HasForeignKey(cc => cc.CategoryId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Course>(b =>
            {
                b.HasOne(c => c.Level)
                 .WithMany(l => l.Courses)
                 .HasForeignKey(c => c.LevelId)
                 .OnDelete(DeleteBehavior.SetNull);
                b.HasMany(c => c.CourseImageUrls)
                 .WithOne(ci => ci.Course)
                 .HasForeignKey(ci => ci.CourseId)
                 .OnDelete(DeleteBehavior.Cascade);
                b.HasMany(c => c.CourseCategories)
                 .WithOne(cc => cc.Course)
                 .HasForeignKey(cc => cc.CourseId)
                 .OnDelete(DeleteBehavior.Cascade);
                b.HasMany(c => c.Modules)
                 .WithOne(m => m.Course)
                 .HasForeignKey(m => m.CourseId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<CourseEnrollment>(b =>
            {
                b.HasOne(ce => ce.Course)
                 .WithMany()
                 .HasForeignKey(ce => ce.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(ce => ce.User)
                 .WithMany()
                 .HasForeignKey(ce => ce.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
            builder.Entity<Lesson>(b =>
            {
                b.HasOne(l => l.Module)
                 .WithMany(m => m.Lessons)
                 .HasForeignKey(l => l.ModuleId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Module>(b =>
            {
                b.HasMany(m => m.Quizzes)
                 .WithOne(q => q.Module)
                 .HasForeignKey(q => q.ModuleId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Option>(b =>
            {
                b.HasOne(o => o.Question)
                 .WithMany(q => q.Options)
                 .HasForeignKey(o => o.QuestionId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Question>(b =>
            {
                b.HasOne(q => q.Quiz)
                 .WithMany(qu => qu.Questions)
                 .HasForeignKey(q => q.QuizId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<QuizResult>(b =>
            {
                b.HasOne(qr => qr.User)
                 .WithMany()
                 .HasForeignKey(qr => qr.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(qr => qr.Quiz)
                 .WithMany()
                 .HasForeignKey(qr => qr.QuizId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Ratings>(b =>
            {
                b.HasOne(r => r.Course)
                 .WithMany()
                 .HasForeignKey(r => r.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(r => r.User)
                 .WithMany()
                 .HasForeignKey(r => r.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
            builder.Entity<WishList>(b =>
            {
                b.HasOne(w => w.Course)
                 .WithMany()
                 .HasForeignKey(w => w.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(w => w.User)
                 .WithMany()
                 .HasForeignKey(w => w.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
            builder.Entity<AdminReviewCourse>(b =>
            {
                b.HasOne(a => a.Course)
                 .WithMany()
                 .HasForeignKey(a => a.CourseId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(a => a.Admin)
                 .WithMany()
                 .HasForeignKey(a => a.AdminId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
            builder.Entity<Message>(b =>
            {
                b.HasOne(m => m.Sender)
                 .WithMany()
                 .HasForeignKey(m => m.SenderId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(m => m.Receiver)
                 .WithMany()
                 .HasForeignKey(m => m.ReceiverId)
                 .OnDelete(DeleteBehavior.Restrict);
            });
            builder.Entity<TransactionHistory>(b =>
            {
                b.HasOne(t => t.User)
                 .WithMany()
                 .HasForeignKey(t => t.UserId)
                 .OnDelete(DeleteBehavior.Restrict);
                b.HasOne(t => t.Course)
                 .WithMany()
                 .HasForeignKey(t => t.CourseId)
                 .OnDelete(DeleteBehavior.SetNull);
            });
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && e.State is EntityState.Added or EntityState.Modified);
            foreach (var entry in entries)
            {
                if (entry.Entity is BaseEntity entity)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entity.DateCreated = DateTime.UtcNow;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        entity.ModifiedDate = DateTime.UtcNow;
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}