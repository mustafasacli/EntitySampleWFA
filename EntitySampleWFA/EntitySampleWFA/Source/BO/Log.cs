using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySampleWFA.Source.BO
{
    [Table("LogEntry", Schema = "SchoolSchem")]
    internal class Log
    {
        internal Log() { LogTime = DateTime.Now; }

        public int Id { get; set; }

        public DateTime LogTime { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        

    }
}
