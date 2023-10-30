using BigTask.Enums;
using BigTask.Helpers;
using BigTask.Intefaces;

namespace BigTask.Models;

public class Employee : Base, IEmployee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public Status status { get; set; }
    public Role role { get; set; }
}
