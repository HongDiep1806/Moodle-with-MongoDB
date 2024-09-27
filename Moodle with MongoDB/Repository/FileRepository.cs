using MongoDB.Driver;
using Moodle_with_MongoDB.Model;
using OfficeOpenXml;
using SharpCompress.Common;

namespace Moodle_with_MongoDB.Repository
{
    public class FileRepository : IFileRepository
    {
        private readonly IMongoCollection<Teacher> _mongoStudentCollection;
        public FileRepository(IMongoDatabase mongoDatabase)
        {
            _mongoStudentCollection = mongoDatabase.GetCollection<Teacher>("Students");
        }
        public void ImportStudentsFromFile()
        {
            var filePath = "E:\\Data Moodle.xlsx";
            List<Teacher> students = new List<Teacher>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];

                for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
                {
                    Teacher student = new Teacher
                    {
                        Name = worksheet.Cells[row, 1].Value.ToString(),
                        DOB = (worksheet.Cells[row, 2].Value.ToString()),
                        Address = worksheet.Cells[row, 3].Value.ToString(),

                    };
                    if (int.Parse(worksheet.Cells[row, 4].Value.ToString()) == 0)
                    {
                        student.IsDeleted = false;
                    }
                    else if (int.Parse(worksheet.Cells[row, 4].Value.ToString()) == 1)
                    {
                        student.IsDeleted = true;
                    }
                    students.Add(student);
                }
            }
            _mongoStudentCollection.InsertMany(students);


        }
    }
}
