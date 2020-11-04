namespace L06
{
    public interface IStudentsRepository
{
    Task<List<StudentEntity>> GetAllStudents();

    Task<StudentEntity> GetStudent(string id);

    Task InsertNewStudent(StudentEntity student);

    Task EditStudent(StudentEntity student);

    Task DeleteStudent(string id);
}
}