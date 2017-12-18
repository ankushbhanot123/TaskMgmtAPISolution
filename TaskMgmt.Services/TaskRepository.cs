using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskMgmt.Domain.Entities;
using TaskMgmt.Data;

namespace TaskMgmt.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private List<Task> Tasks = new List<Task>();
        private TaskMgmtContext db;
        public TaskRepository()
        {
            db = new TaskMgmtContext();
        }

        public Task Add(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("item");
            }
            task.AddedOn = DateTime.Now;
            db.Tasks.Add(task);
            db.SaveChanges();
            
            return task;
        }

        public bool Delete(int id)
        {
            Task task = db.Tasks.FirstOrDefault(s => s.Id == id);
            db.Tasks.Remove(task);
            db.SaveChanges();
            return true;
        }

        public Task Get(int id)
        {
            return db.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Task> GetAll()
        {
            return db.Tasks;
        }

        public bool Update(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException("item");
            }
            task.AddedOn = DateTime.Now;
            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return true;
        }

    }
}