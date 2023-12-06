public class EmployeeController : Controller
{
    private readonly IRepository<Employee> _employeeRepository;

    public EmployeeController(IRepository<Employee> employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<IActionResult> Index()
    {
        var employees = await _employeeRepository.GetAll();
        return View(employees);
    }

    // Implement các hành động CRUD khác
}
