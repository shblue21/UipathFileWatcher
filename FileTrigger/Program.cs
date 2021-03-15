using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileTrigger
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                FileTriggerService fileTriggerService = new FileTriggerService();
            }
            else;
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new FileTriggerService()
                };
                ServiceBase.Run(ServicesToRun);
            }


            
        }

    }

}
