🎓 Online Learning Platform



📖 Giới thiệu

Online Learning Platform là một nền tảng học tập trực tuyến hiện đại, được xây dựng bằng ASP.NET Core MVC. Chúng tôi kết nối học viên (Mentee), giảng viên (Mentor) và quản trị viên (Admin) trong một hệ sinh thái học tập số hóa, nơi bạn có thể quản lý khóa học dễ dàng, theo dõi tiến độ học tập, trao đổi trực tiếp và nâng tầm trải nghiệm học tập. Với thiết kế thân thiện và công nghệ tiên tiến, dự án không chỉ là công cụ học tập mà còn là cầu nối kiến thức bền vững!



"Học tập không giới hạn – Kiến thức không biên giới!" 🌟



🚀 Tính năng nổi bật

Dự án được thiết kế với vai trò người dùng rõ ràng, mang đến trải nghiệm mượt mà cho mọi đối tượng.

\* 🎓 Mentee (Học viên) – Học tập thông minh, tiến bộ rõ ràng

&nbsp; 

&nbsp; -  🔐 Đăng ký / đăng nhập an toàn với ASP.NET Core Identity.

&nbsp; -  📚 Xem danh sách khóa học hấp dẫn, đăng ký (enroll) và mua khóa học chỉ trong vài cú click.

&nbsp; -  📈 Theo dõi tiến độ học tập chi tiết, hoàn thành bài tập (assignments) và kiểm tra kiến thức.

&nbsp; -  ⭐ Đánh giá \& review khóa học sau khi hoàn thành, chia sẻ trải nghiệm với cộng đồng.

&nbsp; -  💳 Tích hợp thanh toán khóa học nhanh chóng và bảo mật.

&nbsp; -  💬 Chat / nhắn tin thời gian thực với mentor qua SignalR.



\* 👨‍🏫 Mentor (Giảng viên) – Giảng dạy dễ dàng, theo dõi hiệu quả

&nbsp; 

&nbsp; -  📝 Tạo mới, chỉnh sửa và quản lý khóa học một cách linh hoạt.

&nbsp; -  📹 Upload tài liệu, video bài giảng, bài tập và lecture chất lượng cao.

&nbsp; -  👥 Theo dõi tiến độ học tập của từng học viên trong khóa học, hỗ trợ kịp thời.



\* 🛡️ Admin – Quản lý toàn diện, kiểm soát chặt chẽ



&nbsp; -  👥 Quản lý người dùng (mentee, mentor): Thêm/sửa/xóa/khóa tài khoản dễ dàng.

&nbsp; -  📂 Quản lý loại khóa học, cấp bậc và hệ thống Q\&A chuyên sâu.

&nbsp; -  ✅ Duyệt và kiểm soát nội dung khóa học từ mentor (approve/moderate) để đảm bảo chất lượng.



🧩 Công nghệ sử dụng



\+ Backend:

C#, ASP.NET Core MVC, ASP.NET Core Identity





\+ Frontend:

Razor Pages, HTML, CSS, JavaScript, Bootstrap





\+ Database:

SQL Server





\+ Real-time:

SignalR





\+ Version Control:

Git





⚙️ Hướng dẫn cài đặt \& chạy dự án

Sẵn sàng khám phá? Hãy làm theo các bước dưới đây để khởi chạy dự án chỉ trong vài phút! ⏱️

1\. Yêu cầu hệ thống



\+  Visual Studio 2022 (hoặc phiên bản mới hơn).

\+  SQL Server 2022 (hoặc tương đương).

\+ .NET 8.0 SDK.



2\. Clone repository

```

&nbsp;   git clone https://github.com/hoangvanduc2k4/OnlineLearning.git

&nbsp;   cd OnlineLearning

```

3\. Cấu hình ứng dụng



&nbsp;  - Mở solution OnlineLearningPlatform.sln trong Visual Studio.

&nbsp;  - Mở file appsettings.json và cập nhật chuỗi kết nối (ConnectionStrings) đến SQL Server của bạn.

&nbsp;  - Build solution để kiểm tra không có lỗi biên dịch: Build > Build Solution (Ctrl+Shift+B).



4\. Khởi tạo database



\+ Nếu chưa cài dotnet-ef, hãy cài hoặc cập nhật:

&nbsp; ```

&nbsp;     dotnet tool install --global dotnet-ef

&nbsp; ```



\+ hoặc

&nbsp; ```

&nbsp;     dotnet tool update --global dotnet-ef

&nbsp; ```



\+ Áp dụng migration và cập nhật database:

&nbsp; ```

&nbsp;     dotnet ef database update

&nbsp; ```







5\. Chạy ứng dụng



\- Khởi chạy project web từ Visual Studio (F5) hoặc bằng lệnh:

```

&nbsp;   dotnet run --project OnlineLearning.Web

```



\- Lưu ý: Nếu gặp lỗi kết nối DB, kiểm tra firewall và quyền truy cập SQL Server.



🙌 Hướng dẫn thành viên commit code

\- Tạo branch mới: Từ nhánh main, đặt tên rõ ràng (ví dụ: feature/wallet-topup hoặc bugfix/course-enroll).

\- Đồng bộ trước khi code:

```

&nbsp;   git checkout main

&nbsp;   git pull origin main

&nbsp;   git checkout -b feature/...  # Tạo branch mới

```



\- Code \& test: Viết code sạch, test kỹ lưỡng, commit thường xuyên.

\- Push khi hoàn thiện:

```

&nbsp;   git add .

&nbsp;   git commit -m "Mô tả commit rõ ràng và ngắn gọn"

&nbsp;   git push origin feature/...

```



\- Tạo Merge Request (MR) từ branch của bạn về main:

\- Bỏ chọn “Delete source branch when MR is accepted” để dễ sửa nếu cần.

\- Chọn “Squash commits when merge request is accepted” để lịch sử commit gọn gàng.





\- Review \& merge: Sau khi được phê duyệt, tiếp tục đóng góp các ý tưởng mới!





Mẹo: Sử dụng Conventional Commits (e.g., feat: add wallet integration) để dễ theo dõi.



🧱 Kiến trúc dự án \& cách code

Dự án theo mô hình MVC với Controller → Service → Repository, đảm bảo code dễ maintain và testable. Chúng tôi sử dụng Generic Repository Pattern với IBaseRepository<T> và BaseRepository<T> để tránh lặp code CRUD cơ bản, chỉ cần extend cho các operation tùy chỉnh.

```

OnlineLearningPlatform/

├── Controllers/

│   └── CourseController.cs          # Xử lý HTTP requests

├── Services/

│   ├── ICourseService.cs            # Interface logic nghiệp vụ

│   └── CourseService.cs             # Triển khai logic

├── Repositories/

│   ├── IBaseRepository.cs           # Generic interface cho CRUD cơ bản

│   ├── BaseRepository.cs            # Generic base class triển khai IBaseRepository<T>

│   ├── ICourseRepository.cs         # Extend IBaseRepository<Course> cho operations tùy chỉnh

│   └── CourseRepository.cs          # Extend BaseRepository<Course>, ICourseRepository

├── Configurations/

│   └── DIConfig.cs                  # Cấu hình Dependency Injection

├── Data/

│   └── OnlineLearningDBContext.cs   # Entity Framework DbContext

├── Models/

│   ├── Entities/

│   │   └── Course.cs                # Model DB entities

│   └── ViewModels/

│       └── CourseViewModel.cs       # DTOs cho UI

└── Program.cs                       # Khởi tạo và gọi DIConfig

```

Vai trò từng layer



Controller: Nhận request từ client, validate input, gọi Service.



Service: Xử lý logic nghiệp vụ cốt lõi, orchestrate giữa layers (gọi Repository).



Repository:



IBaseRepository: Định nghĩa các method generic như Task<T> GetByIdAsync(int id), Task AddAsync(T entity), Task UpdateAsync(T entity), Task DeleteAsync(int id), và Task<IEnumerable<T>> GetAllAsync().



BaseRepository: Triển khai IBaseRepository sử dụng DbContext.Set<T>() cho các operation CRUD chung, hỗ trợ async và include navigation properties.



ICourseRepository và CourseRepository: Extend base cho logic cụ thể như GetCoursesByMentorIdAsync(int mentorId) hoặc search/filter.







Đăng ký DI trong Configurations/DIConfig.cs

```

&nbsp;   public static class DIConfig

&nbsp;       {

&nbsp;           public static void RegisterServices(IServiceCollection services)

&nbsp;           {

&nbsp;               services.AddScoped<ICourseRepository, CourseRepository>();

&nbsp;               services.AddScoped<ICourseService, CourseService>();

&nbsp;           }

&nbsp;       }

```



Mở rộng tính năng mới



Tạo entity mới nếu cần (e.g., Quiz.cs trong /Models/Entities).

Tạo I<Feature>Repository : IBaseRepository<FeatureEntity> và <Feature>Repository : BaseRepository<FeatureEntity>, I<Feature>Repository.

Tạo I<Feature>Service và <Feature>Service (inject IRepository).

Thêm đăng ký vào DIConfig.RegisterServices().

Tạo/Extend Controller để gọi Service.

Thêm migration nếu cần thay đổi DB:dotnet ef migrations add <Name>

dotnet ef database update









Best Practices: Sử dụng async/await cho I/O operations, unit tests với xUnit, và giữ SOLID principles. BaseRepository giúp giảm boilerplate code, nhưng luôn override cho queries phức tạp để tránh N+1 issues.





Cảm ơn bạn đã quan tâm! Hãy star repo nếu thấy hữu ích. ⭐ Hẹn gặp lại trong hành trình học tập! 🚀

