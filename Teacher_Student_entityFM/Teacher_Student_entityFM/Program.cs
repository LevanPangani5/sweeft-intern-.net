// See https://aka.ms/new-console-template for more information
using Teacher_Student_entityFM.DataModels;

Console.WriteLine("Hello, World!");


Teacher[] GetAllTeachersByStudent(string studentName)
{
    using var db = new Context();
    var result = db.Teachers.Where(tich => tich.Pupils.Any(tichst => tichst.Pupil.FirstName == studentName)).ToArray();
    return result;
}