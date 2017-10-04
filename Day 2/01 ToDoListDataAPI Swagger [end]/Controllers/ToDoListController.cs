using System.Collections.Generic;
using System.Web.Http;
using ToDoListDataAPI.Models;
using ToDoListDataAPI.Business;

namespace ToDoListDataAPI.Controllers
{
    public class ToDoListController : ApiController
    {
        ToDoListManager _manager = new ToDoListManager();

        // GET: api/ToDoList
        [HttpGet]
        public IEnumerable<ToDoItem> GetTodoItems()
        {
            return _manager.GetTodoItems();
        }

        // GET: api/ToDoList/5
        [HttpGet]
        public ToDoItem GetTodoItemById(int id)
        {
            return _manager.GetTodoItemById(id);
        }

        // POST: api/ToDoList
        [HttpPost]
        public void UpdateToDoList(ToDoItem todo)
        {
            _manager.InsertTodoItem(todo);
        }

        // PUT: api/ToDoList
        [HttpPut]
        public void Put(ToDoItem todo)
        {
            _manager.EditDescription(todo);
        }

        // DELETE: api/ToDoList/5
        [HttpDelete]
        public void Delete(int id)
        {
            _manager.DeleteById(id);
        }
    }
}

