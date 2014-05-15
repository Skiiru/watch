using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace watch.model
{
    public partial class SqlRepository : IRepository
    {
        [Inject]
        public watchDbDataContext Db { get; set; }
    }
}
