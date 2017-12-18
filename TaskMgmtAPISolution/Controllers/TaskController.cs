using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TaskMgmtAPISolution;
//using TaskMgmtAPISolution.Models;
using TaskMgmt.Repository;
using TaskMgmt.Domain.Entities;

namespace TaskMgmt.Controllers
{
    public class TaskController : ApiController
    {
        readonly ITaskRepository taskRepository;
        //private TaskModel db = new TaskModel();

        public TaskController(ITaskRepository repository)
        {
            this.taskRepository = repository;
        }

        // GET: api/ATasks
        public IEnumerable<Task> GetTasks()
        {
            return taskRepository.GetAll();
        }

        // GET: api/ATasks/5
        [ResponseType(typeof(Task))]
        public IHttpActionResult GetTask(int id)
        {
            Task aTask = taskRepository.Get(id);
            if (aTask == null)
            {
                return NotFound();
            }
            return Ok(aTask);
        }

        // PUT: api/ATasks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTask(int id, Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != task.Id)
            {
                return BadRequest();
            }

            try
            {
                taskRepository.Update(task);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ATasks
        [ResponseType(typeof(Task))]
        public IHttpActionResult PostTask(Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            taskRepository.Add(task);
            return CreatedAtRoute("DefaultApi", new { id = task.Id }, task);
        }

        // DELETE: api/ATasks/5
        [ResponseType(typeof(Task))]
        public IHttpActionResult DeleteTask(int id)
        {
            taskRepository.Delete(id);

            return Ok("Task Deleted Successfully!!");
        }

    }
}