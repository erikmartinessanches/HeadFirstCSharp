using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Queen
    {
        private Worker[] Workers { get; set; }
        private int ShiftNumber { get; set; } = 0;

        public Queen(Worker[] workers)
        {
            Workers = workers;
            //ShiftNumber = 0;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            bool assigned = false;
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].DoThisJob(job, numberOfShifts))
                {
                    assigned = true;
                    break;
                }
            }
            return assigned;
        }

        public string WorkTheNextShift()
        {
            ShiftNumber++;
            string shiftReport = $"Report for shift number {ShiftNumber}\r\n";
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].DidYouFinish())
                {
                    shiftReport += $"Worker number {i+1} finished the job.\r\n";
                }
                if (String.IsNullOrEmpty(Workers[i].CurrentJob))
                {
                    shiftReport += $"Worker {i+1} is not working.\r\n";
                }
                else //Worker has shifts left, report how many.
                {
                    if (Workers[i].ShiftsLeft > 0)
                    {
                        shiftReport +=
                            $" Worker number {i+1} is doing '{Workers[i].CurrentJob}' for {Workers[i].ShiftsLeft} more shifts.\r\n";
                    }
                    else //Last shift
                    {
                        shiftReport +=
                            $"Worker number {i + 1} will be done with '{Workers[i].CurrentJob}' after this shift.\r\n";
                    }
                }
            }
            return shiftReport;
        }
    }
}
