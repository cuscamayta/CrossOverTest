using CrossOverTest.Common;
using CrossOverTest.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossOverTest.Data
{
    public class CrossOverTestRepository
    {
        public List<TaskDTO> Tasks()
        {
            var tasks = CreateTasks();
            return tasks;
        }


        public List<TaskDTO> CreateTasks()
        {
            var task1 = new TaskDTO()
            {
                Owner = "",
                State = TaskState.Pending.ToString(),
                TaskCode = Guid.NewGuid(),
                TypeTask = "Build",
                TaskName = "Tenrox-R1_1235",
                TimeStarted = null,
                Metric = new Metric() { CountTest = 64, Maintainability = 53, Security = 64, Workmanship = 72 },
                Build = new Build() { TimeFinished = "10:46am - 4/17/2014" },
                UnitTest = new Test() { CodeCoveredPercent = 85, TestPassedPercent = 50, TestData = new List<DataChart>() { new DataChart() { y = 142, name = "Test Passed" }, new DataChart() { y = 10, name = "Test Failed" } } },
                FunctionalTest = new Test() { CodeCoveredPercent = 90, TestPassedPercent = 60, TestData = new List<DataChart>() { new DataChart() { y = 4321, name = "Test Passed" }, new DataChart() { y = 2145, name = "Test Failed" } } },
                SubTask = new List<SubTask>()
                {
                    CreateSubTask("Metric",50,100,TaskState.Pending.ToString()),
                    CreateSubTask("Build",45,100,TaskState.Pending.ToString()),
                    CreateSubTask("UnitTest",53,100,TaskState.Pending.ToString()),
                    CreateSubTask("FunctionalTest",68,100,TaskState.Pending.ToString())
                },

            };

            var task2 = new TaskDTO()
            {
                Owner = "Jtuck",
                State = TaskState.Running.ToString(),
                TaskCode = Guid.NewGuid(),
                TaskName = "432462",
                Metric = new Metric() { CountTest = 64, Maintainability = 53, Security = 64, Workmanship = 72 },
                Build = new Build() { TimeFinished = "10:46am - 4/17/2014" },
                UnitTest = new Test() { CodeCoveredPercent = 85, TestPassedPercent = 50, TestData = new List<DataChart>() { new DataChart() { y = 142, name = "Test Passed" }, new DataChart() { y = 10, name = "Test Failed" } } },
                FunctionalTest = new Test() { CodeCoveredPercent = 90, TestPassedPercent = 60, TestData = new List<DataChart>() { new DataChart() { y = 4321, name = "Test Passed" }, new DataChart() { y = 2145, name = "Test Failed" } } },
                TypeTask = "Firewall",
                TimeStarted = "4/18/2014 12:12pm.",
                SubTask = new List<SubTask>()
                {
                    CreateSubTask("Metric",50,200,TaskState.Running.ToString()),
                    CreateSubTask("Build",40,100,TaskState.Pending.ToString()),
                    CreateSubTask("UnitTest",80,100,TaskState.Pending.ToString()),
                    CreateSubTask("FunctionalTest",100,100,TaskState.Pending.ToString())
                }
            };

            var task3 = new TaskDTO()
            {
                Owner = "Samy",
                State = TaskState.Rejected.ToString(),
                TaskCode = Guid.NewGuid(),
                TaskName = "432461",
                Metric = new Metric() { CountTest = 64, Maintainability = 53, Security = 64, Workmanship = 72 },
                Build = new Build() { TimeFinished = "10:46am - 4/17/2014" },
                UnitTest = new Test() { CodeCoveredPercent = 76, TestPassedPercent = 73, TestData = new List<DataChart>() { new DataChart() { y = 142, name = "Test Passed" }, new DataChart() { y = 10, name = "Test Failed" } } },
                FunctionalTest = new Test() { CodeCoveredPercent = 68, TestPassedPercent = 23, TestData = new List<DataChart>() { new DataChart() { y = 4321, name = "Test Passed" }, new DataChart() { y = 2145, name = "Test Failed" } } },
                TypeTask = "Firewall",
                TimeStarted = "4/18/2014 10:53am.",
                SubTask = new List<SubTask>()
                {
                    CreateSubTask("Metric",698,100,TaskState.Rejected.ToString()),
                    CreateSubTask("Build",2654,100,TaskState.Completed.ToString()),
                    CreateSubTask("UnitTest",2654,100,TaskState.Completed.ToString()),
                    CreateSubTask("FunctionalTest",39,100,TaskState.Completed.ToString())
                }
            };

            var task4 = new TaskDTO()
            {
                Owner = "",
                State = TaskState.Completed.ToString(),
                TaskCode = Guid.NewGuid(),
                TaskName = "Tenrox-R1_1234",
                Metric = new Metric() { CountTest = 64, Maintainability = 53, Security = 64, Workmanship = 72 },
                Build = new Build() { TimeFinished = "10:46am - 4/17/2014" },
                UnitTest = new Test() { CodeCoveredPercent = 76, TestPassedPercent = 73, TestData = new List<DataChart>() { new DataChart() { y = 142, name = "Test Passed" }, new DataChart() { y = 10, name = "Test Failed" } } },
                FunctionalTest = new Test() { CodeCoveredPercent = 68, TestPassedPercent = 23, TestData = new List<DataChart>() { new DataChart() { y = 4321, name = "Test Passed" }, new DataChart() { y = 2145, name = "Test Failed" } } },
                TypeTask = "Build",
                TimeStarted = "4/17/2014 9:42am.",
                SubTask = new List<SubTask>()
                {
                    CreateSubTask("Metric",600,100,TaskState.Completed.ToString()),
                    CreateSubTask("Build",2500,100,TaskState.Completed.ToString()),
                    CreateSubTask("UnitTest",3500,100,TaskState.Completed.ToString()),
                    CreateSubTask("FunctionalTest",2654,100,TaskState.Completed.ToString())
                }
            };

            var task5 = new TaskDTO()
            {
                Owner = "Samy",
                State = TaskState.Rejected.ToString(),
                TaskCode = Guid.NewGuid(),
                TaskName = "432460",
                TypeTask = "Firewall",
                TimeStarted = "4/17/2014 7:51am.",
                Metric = new Metric() { CountTest = 64, Maintainability = 53, Security = 64, Workmanship = 72 },
                Build = new Build() { TimeFinished = "10:46am - 4/17/2014" },
                UnitTest = new Test() { CodeCoveredPercent = 85, TestPassedPercent = 50, TestData = new List<DataChart>() { new DataChart() { y = 142, name = "Test Passed" }, new DataChart() { y = 10, name = "Test Failed" } } },
                FunctionalTest = new Test() { CodeCoveredPercent = 90, TestPassedPercent = 60, TestData = new List<DataChart>() { new DataChart() { y = 4321, name = "Test Passed" }, new DataChart() { y = 2145, name = "Test Failed" } } },
                SubTask = new List<SubTask>()
                {
                    CreateSubTask("Metric",6325,100,TaskState.Rejected.ToString()),
                    CreateSubTask("Build",1254,100,TaskState.Pending.ToString()),
                    CreateSubTask("UnitTest",8974,100,TaskState.Pending.ToString()),
                    CreateSubTask("FunctionalTest",9658,100,TaskState.Pending.ToString())
                }
            };

            var task6 = new TaskDTO()
            {
                Owner = "Samy",
                State = TaskState.Accepted.ToString(),
                TaskCode = Guid.NewGuid(),
                TaskName = "432459",
                Metric = new Metric() { CountTest = 64, Maintainability = 53, Security = 64, Workmanship = 72 },
                Build = new Build() { TimeFinished = "10:46am - 4/17/2014" },
                UnitTest = new Test() { CodeCoveredPercent = 90, TestPassedPercent = 83, TestData = new List<DataChart>() { new DataChart() { y = 568, name = "Test Passed" }, new DataChart() { y = 350, name = "Test Failed" } } },
                FunctionalTest = new Test() { CodeCoveredPercent = 80, TestPassedPercent = 30, TestData = new List<DataChart>() { new DataChart() { y = 8952, name = "Test Passed" }, new DataChart() { y = 4156, name = "Test Failed" } } },
                TypeTask = "Firewall",
                TimeStarted = "4/16/2014 6:43am.",
                SubTask = new List<SubTask>()
                {
                    CreateSubTask("Metric",5874,100,TaskState.Completed.ToString()),
                    CreateSubTask("Build",2598,100,TaskState.Completed.ToString()),
                    CreateSubTask("UnitTest",9688,100,TaskState.Completed.ToString()),
                    CreateSubTask("FunctionalTest",9874,100,TaskState.Completed.ToString())
                }
            };

            return new List<TaskDTO>() { task1, task2, task3, task4, task5, task6 };
        }


        private SubTask CreateSubTask(string nameSubTask, int processTime, int countProcess, string state)
        {
            return new SubTask()
            {
                SubTaskCode = Guid.NewGuid(),
                SubTaskName = nameSubTask,
                ProcessTime = processTime,
                CountProccess = countProcess,
                State = state
            };
        }

    }
}
