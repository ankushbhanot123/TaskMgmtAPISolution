namespace TaskMgmt.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using TaskMgmt.Domain.Entities;

    public class TaskMgmtContext : DbContext
    {
        // Your context has been configured to use a 'TaskModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TaskMgmtAPISolution.TaskModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TaskModel' 
        // connection string in the application configuration file.
        public TaskMgmtContext()
            : base("name=TaskMgmtContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TaskMgmtContext>());
        }
        public DbSet<Task> Tasks { get;set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}