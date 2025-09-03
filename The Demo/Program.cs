namespace The_Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Revision
            // EF Core : ORM in .NET
            // ORM

            // 1. Mapping 
            //      Code First [Generate Table Per Class]
            //      DB First   [Generate Class Per Table]
            // 2. L2E [C# Code (LINQ) ---> EF Core ---> SQL DB]

            // 3 Ways Generate
            // 1. TPC : Table Per Class
            // 2. TPH : Table Per Hierarichy
            // 2. TPCC : Table Per Concret Class


            // Code 
            #endregion

            #region CRUD Operation

            //// CRUD Operation
            //// Create - Read - Update - Delete

            //AppDbContext context = new AppDbContext();

            ////try
            ////{
            ////    //Code
            ////}
            ////finally
            ////{

            ////context.Dispose();
            ////}

            ////using (AppDbContext context = new AppDbContext())
            ////{
            ////    // CRUD

            ////}

            //using AppDbContext context = new AppDbContext();

            //// Create - Insert


            //var employee = new Employee()
            //{

            //    Name = "Mohamed Ali",
            //    Salary = 12000,
            //    Address = "Cairo",
            //    Age = 25

            //};


            // employee.Name = "khaled";

            // Console.WriteLine(context.Entry(employee).State); // Detached



            // //context.Employees.Add(employee);

            // context.Add(employee);

            // Console.WriteLine(context.Entry(employee).State); // Added

            //var Result = context.SaveChanges();

            // Console.WriteLine(context.Entry(employee).State); // Unchanged

            // employee.Name = "omar";

            // Console.WriteLine(context.Entry(employee).State); // Modified


            // Console.WriteLine(Result); // 1
            //context.Employees.Add(employee);
            // context.SaveChanges();
            //Console.WriteLine(context.Entry(employee).State);
            //context.Entry(employee).State = EntityState.Added;
            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges();



            #endregion

            #region Update
            // // Update
            // AppDbContext context = new AppDbContext();


            //var result = context.Employees.FirstOrDefault(e => e.Id == 20);

            // Console.WriteLine(context.Entry(result).State);

            // result.Name = "omar Ali";

            // Console.WriteLine(context.Entry(result).State);

            // context.Update(result);

            // Console.WriteLine(context.Entry(result).State);

            // //context.SaveChanges();

            // //Console.WriteLine(context.Entry(result).State); 
            #endregion

            #region Delete

            // //Delete

            // AppDbContext context = new AppDbContext();

            //var result = context.Employees.FirstOrDefault(e => e.Id == 20);

            // context.Employees.Remove(result);

            // Console.WriteLine(context.Entry(result).State);

            // context.SaveChanges();

            // Console.WriteLine(context.Entry(result).State); 
            #endregion

            //Employee employee = new Employee();

            //Department department = new Department();
            //department.manager
        }
    }
}
