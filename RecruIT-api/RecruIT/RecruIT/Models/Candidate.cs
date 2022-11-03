namespace RecruIT.Models;

public class Candidate
{
    public Guid Id {get; }
    public string Name {get; }
    public string Cpf {get; }
    public int Age {get; }
    public bool IsActive {get; }
    public string Email {get; }
    public string Bio {get; }
    public Object Skills {get; }
    public List<string> Links {get; }

    public Candidate(Guid id, string name, string cpf, int age, bool isActive, string email, string bio, Object skills, List<string> links)
    {
        //enforce values 
        Id = id;
        Name = name;
        Cpf = cpf;
        Age = age;
        IsActive = isActive;
        Email = email;
        Bio = bio;
        Skills = skills;
        Links = links;
    }
}
