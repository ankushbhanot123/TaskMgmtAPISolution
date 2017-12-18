using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskMgmt.Domain.Entities;

namespace TaskMgmt.Repository
{
    public interface ITaskRepository
    {
        Task Add(Task task);
        bool Delete(int id);
        Task Get(int id);
        IEnumerable<Task> GetAll();
        bool Update(Task task);
    }
}