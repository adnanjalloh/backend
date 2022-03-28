using CCC.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace CCC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SeedData
            PrepareDepartmentValues(modelBuilder);

            PrepareEmployeeValues(modelBuilder);

            PrepareLeaveTypesValues(modelBuilder);

            PrepareLeaveValues(modelBuilder);

            PrepareExpenseClaimValues(modelBuilder);

            PrepareExpenseClaimDetailValues(modelBuilder);
            #endregion

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<ExpenseClaim> ExpenseClaims { get; set; }
        public DbSet<ExpenseClaimDetail> ExpenseClaimDetails { get; set; }



        #region SeedData

        private void PrepareDepartmentValues(ModelBuilder modelBuilder)
        {
            var departments = new List<Department>
            {
                new Department { DepartmentId = 1, Title = "Develpment"},
                new Department { DepartmentId = 2, Title = "Hr"},
                new Department { DepartmentId = 3, Title = "Sales"},
                new Department { DepartmentId = 4, Title = "Support"},
            };
            modelBuilder.Entity<Department>().HasData(departments);
        }
        private void PrepareEmployeeValues(ModelBuilder modelBuilder)
        {
            var employess = new List<Employee>
            {
                new Employee { EmployeeId = 1,Email = "Ahmed@ccc.com",Address = "Test",Name = "Ahmed", DepartmentId = 1 },
                new Employee { EmployeeId = 2,Email = "Mohmmed@ccc.com",Address = "Test",Name = "Mohmmed", DepartmentId = 2 },
                new Employee { EmployeeId = 3,Email = "Ali@ccc.com",Address = "Test",Name = "Ali", DepartmentId = 3 },
                new Employee { EmployeeId = 4,Email = "Sanaa@ccc.com",Address = "Test",Name = "Sanaa", DepartmentId = 4 },
                new Employee { EmployeeId = 5,Email = "Raghd@ccc.com",Address = "Test",Name = "Raghd", DepartmentId = 1 },
                new Employee { EmployeeId = 6,Email = "Saja@ccc.com",Address = "Test",Name = "Saja", DepartmentId = 2 },
                new Employee { EmployeeId = 7,Email = "Tamer@ccc.com",Address = "Test",Name = "Tamer", DepartmentId = 3 },
                new Employee { EmployeeId = 8,Email = "Nasim@ccc.com",Address = "Test",Name = "Nasim", DepartmentId = 4 },
                new Employee { EmployeeId = 9,Email = "Basil@ccc.com",Address = "Test",Name = "Basil", DepartmentId = 1 },
                new Employee { EmployeeId = 10,Email = "Marwa@ccc.com",Address = "Test",Name = "Marwa", DepartmentId = 2 },
                new Employee { EmployeeId = 11,Email = "Marwan@ccc.com",Address = "Test",Name = "Marwan", DepartmentId = 1 },
            };

            modelBuilder.Entity<Employee>().HasData(employess);
        }
        private void PrepareLeaveTypesValues(ModelBuilder modelBuilder)
        {
            var leaveTypes = new List<LeaveType>
            {
                new LeaveType { LeaveTypeId = 1, Title = "Privilege Leave" },
                new LeaveType { LeaveTypeId = 2, Title = "Earned Leave" },
                new LeaveType { LeaveTypeId = 3, Title = "Annual Leave" },
                new LeaveType { LeaveTypeId = 4, Title = "Casual Leave" },
                new LeaveType { LeaveTypeId = 5, Title = "Sick Leave" },
                new LeaveType { LeaveTypeId = 6, Title = "Maternity Leave" },
                new LeaveType { LeaveTypeId = 7, Title = "Marriage Leave" },
                new LeaveType { LeaveTypeId = 8, Title = "Paternity Leave" },
                new LeaveType { LeaveTypeId = 9, Title = "Leave Without Pay" },
                new LeaveType { LeaveTypeId = 10, Title = "Loss of Pay" },
            };

            modelBuilder.Entity<LeaveType>().HasData(leaveTypes);
        }
        private void PrepareLeaveValues(ModelBuilder modelBuilder)
        {
            var leaves = new List<Leave>
            {
                new Leave { LeaveId = 1, From = DateTime.UtcNow.AddDays(-1), To = DateTime.UtcNow.AddDays(5), EmployeeId = 1, LeaveTypeId = 1, Note = "Test note" },
                new Leave { LeaveId = 2, From = DateTime.UtcNow.AddDays(-10), To = DateTime.UtcNow.AddDays(-2), EmployeeId = 2, LeaveTypeId = 2, Note = "Test note" },
                new Leave { LeaveId = 3, From = DateTime.UtcNow.AddDays(-20), To = DateTime.UtcNow.AddDays(-5), EmployeeId = 3, LeaveTypeId = 3, Note = "Test note" },
                new Leave { LeaveId = 4, From = DateTime.UtcNow.AddDays(-4), To = DateTime.UtcNow.AddDays(-8), EmployeeId = 4, LeaveTypeId = 4, Note = "Test note" },
                new Leave { LeaveId = 5, From = DateTime.UtcNow.AddDays(-1), To = DateTime.UtcNow.AddDays(-2), EmployeeId = 5, LeaveTypeId = 5, Note = "Test note" },
                new Leave { LeaveId = 6, From = DateTime.UtcNow.AddDays(8), To = DateTime.UtcNow.AddDays(16), EmployeeId = 6, LeaveTypeId = 6, Note = "Test note" },
                new Leave { LeaveId = 7, From = DateTime.UtcNow.AddDays(5), To = DateTime.UtcNow.AddDays(15), EmployeeId = 7, LeaveTypeId = 7, Note = "Test note" },
                new Leave { LeaveId = 8, From = DateTime.UtcNow.AddDays(-1), To = DateTime.UtcNow.AddDays(-6), EmployeeId = 8, LeaveTypeId = 8, Note = "Test note" },
                new Leave { LeaveId = 9, From = DateTime.UtcNow.AddDays(-3), To = DateTime.UtcNow.AddDays(-6), EmployeeId = 1, LeaveTypeId = 9, Note = "Test note" },
                new Leave { LeaveId = 10, From = DateTime.UtcNow.AddDays(-100), To = DateTime.UtcNow.AddDays(-79), EmployeeId = 2, LeaveTypeId = 10, Note = "Test note" },
                new Leave { LeaveId = 11, From = DateTime.UtcNow.AddDays(-80), To = DateTime.UtcNow.AddDays(-54), EmployeeId = 3, LeaveTypeId = 1, Note = "Test note" },
                new Leave { LeaveId = 12, From = DateTime.UtcNow.AddDays(-90), To = DateTime.UtcNow.AddDays(-52), EmployeeId = 4, LeaveTypeId = 2, Note = "Test note" },
                new Leave { LeaveId = 13, From = DateTime.UtcNow.AddDays(-86), To = DateTime.UtcNow.AddDays(-52), EmployeeId = 5, LeaveTypeId = 3, Note = "Test note" },
                new Leave { LeaveId = 14, From = DateTime.UtcNow.AddDays(-14), To = DateTime.UtcNow.AddDays(-6), EmployeeId = 6, LeaveTypeId = 4, Note = "Test note" },
                new Leave { LeaveId = 15, From = DateTime.UtcNow.AddDays(-88), To = DateTime.UtcNow.AddDays(-44), EmployeeId = 11, LeaveTypeId = 5, Note = "Test note" },
                new Leave { LeaveId = 16, From = DateTime.UtcNow.AddDays(-44), To = DateTime.UtcNow.AddDays(-22), EmployeeId = 8, LeaveTypeId = 6, Note = "Test note" },
                new Leave { LeaveId = 17, From = DateTime.UtcNow.AddDays(-52), To = DateTime.UtcNow.AddDays(-29), EmployeeId = 9, LeaveTypeId = 7, Note = "Test note" },
                new Leave { LeaveId = 18, From = DateTime.UtcNow.AddDays(-150), To = DateTime.UtcNow.AddDays(-80), EmployeeId = 5, LeaveTypeId = 8, Note = "Test note" },
                new Leave { LeaveId = 19, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-100), EmployeeId = 4, LeaveTypeId = 9, Note = "Test note" },
                new Leave { LeaveId = 20, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-54), EmployeeId = 3, LeaveTypeId = 10, Note = "Test note" },
                new Leave { LeaveId = 21, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-64), EmployeeId = 2, LeaveTypeId = 1, Note = "Test note" },
                new Leave { LeaveId = 22, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-85), EmployeeId = 1, LeaveTypeId = 2, Note = "Test note" },
                new Leave { LeaveId = 23, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-53), EmployeeId = 7, LeaveTypeId = 3, Note = "Test note" },
                new Leave { LeaveId = 24, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-15), EmployeeId = 8, LeaveTypeId = 4, Note = "Test note" },
                new Leave { LeaveId = 25, From = DateTime.UtcNow.AddDays(-160), To = DateTime.UtcNow.AddDays(-1), EmployeeId = 10, LeaveTypeId = 5, Note = "Test note" },
            };

            modelBuilder.Entity<Leave>().HasData(leaves);
        }
        private void PrepareExpenseClaimValues(ModelBuilder modelBuilder)
        {
            var expenseClaims = new List<ExpenseClaim>
            {
                new ExpenseClaim {ExpenseClaimId = 1, Date = DateTime.UtcNow, Status = (int)ExpenseClaimStatus.Claimed, Description ="Test", EmployeeId = 1, Total = 2000},
                new ExpenseClaim {ExpenseClaimId = 2, Date = DateTime.UtcNow, Status = (int)ExpenseClaimStatus.Claimed, Description ="Test2", EmployeeId = 2, Total = 2000},
            };

            modelBuilder.Entity<ExpenseClaim>().HasData(expenseClaims);
        }
        private void PrepareExpenseClaimDetailValues(ModelBuilder modelBuilder)
        {
            var expenseClaimDetails = new List<ExpenseClaimDetail>
            {
                new ExpenseClaimDetail {ExpenseClaimDetailId = 1, Description = "Meals", ExpenseClaimId = 1, Date = DateTime.UtcNow, Total = 1200},
                new ExpenseClaimDetail {ExpenseClaimDetailId = 2, Description = "Taxi", ExpenseClaimId = 1, Date = DateTime.UtcNow, Total = 500},
                new ExpenseClaimDetail {ExpenseClaimDetailId = 3, Description = "Tools Rental", ExpenseClaimId = 1, Date = DateTime.UtcNow, Total = 300},
                new ExpenseClaimDetail {ExpenseClaimDetailId = 4, Description = "Meals", ExpenseClaimId = 2, Date = DateTime.UtcNow, Total = 1200},
                new ExpenseClaimDetail {ExpenseClaimDetailId = 5, Description = "Taxi", ExpenseClaimId = 2, Date = DateTime.UtcNow, Total = 500},
                new ExpenseClaimDetail {ExpenseClaimDetailId = 6, Description = "Tools Rental", ExpenseClaimId = 2, Date = DateTime.UtcNow, Total = 300},
            };

            modelBuilder.Entity<ExpenseClaimDetail>().HasData(expenseClaimDetails);
        }

        #endregion





    }
}
