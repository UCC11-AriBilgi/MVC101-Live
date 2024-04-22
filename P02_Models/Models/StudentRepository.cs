namespace P02_Models.Models
{
    public class StudentRepository : IStudentRepository
    {
        // Db tarafında olmayan InMemory seklinde kullanılacak olan kayıtlar oluşturacağım. Ve bunları bir liste yapısı seklinde tutacağım.

        public List<Student> Students()
        {
            return new List<Student>()
            {
                new Student() { Id=1, Name="Stu1", EMail="stu1@gmail.com", Phone="012344445566", Gender="E" },
                new Student() { Id=2, Name="Stu2", EMail="stu2@gmail.com", Phone="01235556677", Gender="K" },
                new Student() { Id=3, Name="Stu3", EMail="stu3@gmail.com", Phone="01236667788", Gender="K" }

            };
        }


        public Student Get(int id)
        {
            // Oluşturduğum datadan ilgili Id ye göre ekrana getirmek istediğim kayıdı get,irecek olan bolüm

            // Bulmaya çalışacak eğer bulursa return ile geri postaycak bulamazsa yeni bir kayıt acacak...
            return Students().FirstOrDefault(e => e.Id == id) ?? new Student();
            
        }
    }
}
