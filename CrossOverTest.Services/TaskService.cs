using CrossOverTest.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossOverTest.Services
{
    public class TaskService : ServiceBase
    {
        public List<TaskDTO> GetTasks()
        {
            try
            {
                var tasks = Respository.Tasks();
                return tasks;
            }
            catch (Exception exception)
            {
                //log Exception                
            }
            return new List<TaskDTO>();
        }

    }
}
