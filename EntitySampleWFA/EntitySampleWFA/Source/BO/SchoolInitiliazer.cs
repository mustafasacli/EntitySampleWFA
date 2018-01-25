using System.Data.Entity;

namespace EntitySampleWFA.Source.BO
{
    internal class SchoolInitiliazer : DropCreateDatabaseIfModelChanges<SchoolContext>
    //CreateDatabaseIfNotExists<SchoolContext>
    //DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            /*
            var students = new List<Student>
            {
                new Student{StudentName="James Dean",DateOfBirth=DateTime.Parse("2014-01-02")},
                new Student{StudentName="Thomas Lynda",DateOfBirth=DateTime.Parse("2014-11-02")}
            };

            foreach (var item in students)
            {
                context.Students.Add(item);
            }

            context.SaveChanges();
            */
        }
    }
}