using KodlamaIO_3.Business.Concretes;
using KodlamaIO_3.DataAccess.Concretes;
using KodlamaIO_3.Entities.Concretes;

CourseService courseService = new(new CourseDal());
CategoryService categoryService = new CategoryService(new CategoryDal());
InstructorService instructorService = new InstructorService(new InstructorDal());

List<Course> courses = courseService.GetAll();
Console.WriteLine("CRUD işlemlerinden Read:\n");

//kursu yazdırma
foreach (Course course in courses)
{
    Console.WriteLine($"Kurs adı:{course.Name}; Kurs Açıklaması:{course.Description}; Kurs Fiyatı:{course.Price}");
}
Console.WriteLine("----------------------------------");
Console.WriteLine("CRUD işlemlerinden Create:\n");

//kurs ekle,kategori ekle,eğitmen ekle
categoryService.Add(new Category() { CategoryId = 4, Name = "Database" });
courseService.Add(new Course() { InstructorId = 1, CategoryId = 2, Description = "Yazılım Geliştirici Yetiştirme Kampı (Senior .Net)", CourseId = 4, Name = "Senior .Net", Price = 40 });
instructorService.Add(new Instructor() { InstructorId = 3, Name = "Ömer Sargın" });

List<Category> categories = categoryService.GetAll();
//Eklenen kategoriyi görüntüleme
foreach (Category category in categories)
{
    Console.WriteLine($"{category.Name}  ; {category.CategoryId}");
}

Console.WriteLine("----------------------------------");
Console.WriteLine("CRUD işlemlerinden Delete:\n");

instructorService.Delete(3); //ömer sargın silindi.
List<Instructor> instructors = instructorService.GetAll();
foreach (Instructor instructor in instructors)//silindikten sonra eğitmen listesini kontrol et.
{
    Console.WriteLine(instructor.Name);
}
Console.WriteLine("----------------------------------");
Console.WriteLine("CRUD işlemlerinden Update:\n");


courseService.Update(new Course() { InstructorId = 6, CategoryId = 3, Description = "JAVA YAZILIMCI YETİŞTİRME KAMPI", CourseId = 4, Name = "2022 JAVA EĞİTİMİ", Price = 60 });


foreach (Course course in courses)
{
    Console.WriteLine($"Kurs adı:{course.Name};Kurs Açıklaması:{course.Description};Kurs Fiyatı:{course.Price}");
}
