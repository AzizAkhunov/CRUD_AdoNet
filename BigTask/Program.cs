using BigTask;
using BigTask.Models;

var employee = new Employee();






Console.WriteLine("\t\t1.Add\n\t\t2.Delete\n\t\t3.DeepDelete\n\t\t4.GetAll\n\t\t5.GetById\n\t\t0.Exit");
int change = Convert.ToInt32(Console.ReadLine());
switch (change)
{
    case 1:
        employee.Id = 1;
        Console.Write("Ismingizni kiritng: ");
        employee.Name = Console.ReadLine();
        Console.Write("Familiyangizni kiriting: ");
        employee.Surname = Console.ReadLine();
        Console.Write("Email: ");
        employee.Email = Console.ReadLine();
        Console.Write("Status: ");
        employee.CreatedDate = Convert.ToString(DateTime.Now);
        Service.Create(employee);
        break;
    case 2:
        Console.Write("Uchirmoqchi bulgan odamni Idisini kiriting: ");
        Service.DeleteById(int.Parse(Console.ReadLine()));
        break;
    case 3:
        Console.Write("Uchirmoqchi bulgan odamni Idisini kiriting: ");
        Service.DeepDelete(int.Parse(Console.ReadLine()));
        break;
    case 4:
        Service.GetAll();
        break;
    case 5:
        Console.Write("Id sini kiriting: ");
        Service.GetById(int.Parse(Console.ReadLine()));
        break;
    case 0:
        return;
}