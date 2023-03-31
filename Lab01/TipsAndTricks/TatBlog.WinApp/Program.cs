//using TatBlog.Core.Entities;
//using TatBlog.Data.Contexts;
//using TatBlog.Data.Seeders;
//using TatBlog.Services.Blogs;
//using TatBlog.WinApp;

//var context = new BlogDbContext();
//var seeder = new DataSeeder(context);
//seeder.Initialize();
//var authors = context.Authors.ToList();
//Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12}",
//    "ID", "Full Name", "Email", "Joined Dated");
//foreach (var author in authors)
//{
//    Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12:MM/dd/yyyy}",
//        author.Id, author.FullName, author.Email, author.JoinedDay);
//}

//Lấy kèm tên tác giả và chuyên mục
//var context = new BlogDbContext();
//var posts = context.Posts
//    .Where(p => p.Published)
//    .OrderBy(p => p.Title)
//    .Select(p => new
//    {
//        Id = p.Id,
//        Title = p.Title,
//        ViewCout = p.ViewCount,
//        PostedDate = p.PostedDate,
//        Author = p.Author.FullName,
//        Category = p.Category.Name,
//    }
//    )
//    .ToList();
//Xuất danh sách
//foreach (var post in posts)
//{
//    Console.WriteLine("ID:{0}", post.Id);
//    Console.WriteLine("Title:{0}", post.Title);
//    Console.WriteLine("View:{0}", post.ViewCout);
//    Console.WriteLine("Date:{0:MM//dd/yyyy}", post.PostedDate);
//    Console.WriteLine("Author:{0}", post.Author);
//    Console.WriteLine("Category:{0}", post.Category);
//    Console.WriteLine("".PadRight(80, '-'));
//}

// 3 bài viết xem nhiều nhất
//var context = new BlogDbContext();
//IBlogRepository blogRepo = new BlogRepository(context);
//var posts = await blogRepo.GetPoPularArticlesAsysc(3);
//foreach (var post in posts)
//{
//    Console.WriteLine("ID:{0}", post.Id);
//    Console.WriteLine("Title:{0}", post.Title);
//    Console.WriteLine("View:{0}", post.ViewCount);
//    Console.WriteLine("Date:{0:MM//dd/yyyy}", post.PostedDate);
//    Console.WriteLine("Author:{0}", post.Author.FullName);
//    Console.WriteLine("Category:{0}", post.Category.Name);
//    Console.WriteLine("".PadRight(80, '-'));
//}

//var context = new BlogDbContext();
//IBlogRepository blogRepo = new BlogRepository(context);
//var categories = await blogRepo.GetCategoriesAsyns();
//Console.WriteLine("{0,-5}{1,-50}{2,10}", "ID", "Name", "Count");
//foreach (var item in categories)
//{
//    Console.WriteLine("{0,-5}{1,-50}{2,10}", item.Id, item.Name, item.PostCount);

//}
// text
//var context = new BlogDbContext();
//IBlogRepository blogRepo = new BlogRepository(context);
//var pagingParams = new PagingParams
//{
//    PageNumber = 1,
//    PageSize = 8,
//    SortColumn = "Name",
//    SortOrder = "DESC"
//};
//var tagList = await blogRepo.GetPagedTagsAsync(pagingParams);
//Console.WriteLine("{0,-5}{1,-50}{2,10}", "ID", "Name", "Count");
//foreach (var item in tagList)
//{
//    Console.WriteLine("{0,-5}{1,-50}{2,10}", item.Id, item.Name, item.PostCount);

//}


// C.THUC HANH

//using TatBlog.Data.Contexts;
//using TatBlog.Data.Seeders;
//using TatBlog.Services.Blogs;
//using TatBlog.WinApp;

//var context = new BlogDbContext();

//var blogRepo = new BlogRepository(context);

//1. Hãy tạo các lớp và định nghĩa các phương thức cần thiết để truy vấn dữ liệu theo các yêu cầu sau:

//a. Tìm một thẻ tag theo tên định danh slug

//var tag = await blogRepo.FindTag_SlugAsync("c#");

//Console.WriteLine("{0, -5} {1, -20} {2, 10}", "ID", "Name", "UrlSlug");
//Console.WriteLine("{0, -5} {1, -20} {2, 10}", tag.Id, tag.Name, tag.UrlSlug);

//Console.ReadKey();

//c. Lấy danh sách tất cả các thẻ (Tag) kèm theo số bài viết chứa thẻ đó. Kết quả trả về kiểu IList<TagItem>

//var tags = await blogRepo.GetAllTagsWithPostAsync();

//Console.WriteLine("{0, -5} {1, -50} {2, 10} ", "ID", "Name", "Post count");
//foreach (var tag in tags)
//{

//    Console.WriteLine("{0, -5} {1, -50} {2, 10}", tag.Id, tag.Name, tag.PostCount);
//}

//Console.ReadKey();

//d. Xóa một thẻ theo mã cho trước

//var tags = await blogRepo.GetAllTagsWithPostAsync();
//Console.WriteLine("{0, -5} {1, -50} {2, 10} ", "ID", "Name", "Post count");
//foreach (var tag in tags)
//{

//    Console.WriteLine("{0, -5} {1, -50} {2, 10}", tag.Id, tag.Name, tag.PostCount);
//}

//Console.WriteLine("Xoa the thanh cong");

//await blogRepo.DeleteTagByIDAsync(20);
//tags = await blogRepo.GetAllTagsWithPostAsync();

//Console.WriteLine("{0, -5} {1, -50} {2, 10} ", "ID", "Name", "Post count");
//foreach (var tag in tags)
//{

//    Console.WriteLine("{0, -5} {1, -50} {2, 10}", tag.Id, tag.Name, tag.PostCount);
//}
//Console.ReadKey();

//e. Tìm một chuyên mục (Category) theo tên định danh (slug)

//var category = await blogRepo.FindCategory_SlugAsync("html");

//Console.WriteLine("{0, -5} {1, -20} {2, 10}", "ID", "Name", "UrlSlug");
//Console.WriteLine("{0, -5} {1, -20} {2, 10}", category.Id, category.Name, category.UrlSlug);

//Console.ReadKey();

//i. Kiểm tra tên định danh (slug) của một chuyên mục đã tồn tại hay chưa
//bool result = await blogRepo.CheckCategoryExist_Async("algorithms");

//Console.WriteLine(result);
//Console.ReadKey();



