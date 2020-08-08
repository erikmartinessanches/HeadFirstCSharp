using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_with_interfaces
{
    class Worker : Bee
    {
        public string CurrentJob { get; private set; }
        public int ShiftsLeft => ShiftsToWork - ShiftsWorked;
        private string[] JobsICanDo { get; set; }
        private int ShiftsWorked { get; set; }
        private int ShiftsToWork { get; set; }  //Assigned number of shifts to work (per job).
        private const double honeyUnitsPerShiftWorked = 0.65;

        public Worker(string[] jobs, double weightMg): base(weightMg)
        {
            JobsICanDo = new string[jobs.Length];
            this.JobsICanDo = jobs;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(CurrentJob))
            {
                return false; //Already doing this job.
            }
            foreach (var jobICanDo in JobsICanDo)
            {
                if (jobICanDo == job)
                {
                    CurrentJob = job;
                    ShiftsToWork = numberOfShifts;
                    ShiftsWorked = 0;
                    return true;
                }
            }

            return false;
        }

        /* This method should only return true if this is the VERY LAST shift that
         * he's doing the job.
         * */
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(CurrentJob)) //If not working, just return false.
            {
                return false;
            }
            ShiftsWorked++;
            if (ShiftsWorked > ShiftsToWork)
            {
                ShiftsToWork = 0;
                ShiftsWorked = 0;
                CurrentJob = "";
                return true;
            }
            return false;
        }

        public override double HoneyConsumptionRate() => base.HoneyConsumptionRate() + honeyUnitsPerShiftWorked * ShiftsWorked;
    }
}
