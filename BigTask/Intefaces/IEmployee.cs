using BigTask.Enums;

namespace BigTask.Intefaces;

public interface IEmployee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public Status status { get; set; }
    public Role role { get; set; }
}
