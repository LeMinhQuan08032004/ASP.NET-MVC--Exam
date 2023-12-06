public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public void ConfigureServices(IServiceCollection services)
    {
        // ...
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        // ...
    }
    
}