using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossOverTest.DTO
{
    public class TaskDTO
    {
        public Guid TaskCode { get; set; }
        public string TaskName { get; set; }
        public string TypeTask { get; set; }
        public string Owner { get; set; }
        public string TimeStarted { get; set; }
        public string State { get; set; }
        public List<SubTask> SubTask { get; set; }

        public Metric Metric { get; set; }
        public Build Build { get; set; }
        public Test UnitTest { get; set; }
        public Test FunctionalTest { get; set; }

    }

    public class SubTask
    {
        public Guid SubTaskCode { get; set; }
        public string SubTaskName { get; set; }
        public int ProcessTime { get; set; }
        public int CountProccess { get; set; }
        public string State { get; set; }


    }


    public class Metric
    {
        public int CountTest { get; set; }
        public int Maintainability { get; set; }
        public int Security { get; set; }
        public int Workmanship { get; set; }
    }

    public class Build
    {
        public string TimeFinished { get; set; }
    }

    public class Test
    {
        public int CodeCoveredPercent { get; set; }

        public List<DataChart> TestData { get; set; }
        //public List<DataChart> FunctionalTest { get; set; }
        public int TestPassedPercent { get; set; }
    }

    public class DataChart
    {
        public string name { get; set; }
        public int y { get; set; }
    }

    public class TaskInfo
    {
        public string Title { get; set; }
        public string Owner { get; set; }
        public string Result { get; set; }
    }



}
