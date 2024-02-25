namespace WithOutDb.Models;

public class Student
{
    public int Id { get; set; } 
    public int Roll { get; set; } = default;
    public string ?Name { get; set; } = default;
    public string ?Department { get; set; } = default;
    public string  ?Semister { get; set; } = default;
    public string ?Email { get; set; } = default;

    public Student(int Id,int Roll, string Name, string Department, string Semister, string Email)
    {
        this.Id = Id;
        this.Roll = Roll;
        this.Name = Name;
        this.Department = Department;
        this.Semister = Semister;
        this.Email = Email;
    }
    public Student()
    {
        
    }
}
