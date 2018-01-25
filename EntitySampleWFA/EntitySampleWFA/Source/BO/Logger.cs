using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySampleWFA.Source.BO
{
    class Logger
    {
        public static void LogException(Exception ex)
        {
            try
            {
                if (ex != null)
                {
                    using (SchoolContext cntxt = new SchoolContext())
                    {
                        Log _log = new Log() { Message = ex.Message, StackTrace = ex.StackTrace };
                        DateTime dt = _log.LogTime;
                        cntxt.Logs.Add(_log);
                        cntxt.SaveChanges();
                        if (ex.InnerException != null)
                        {
                            _log = new Log() { LogTime = dt, Message = ex.InnerException.Message, StackTrace = ex.InnerException.StackTrace };
                            cntxt.Logs.Add(_log);
                            cntxt.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

    }
}
