using CrossOverTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossOverTest.Services
{
    public class ServiceBase
    {

        private CrossOverTestRepository _repository;

        internal CrossOverTestRepository Respository
        {
            get
            {
                return _repository ?? new CrossOverTestRepository();
            }
        }
    }
}
