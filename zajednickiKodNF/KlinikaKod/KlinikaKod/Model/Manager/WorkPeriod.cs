/***********************************************************************
 * Module:  WorkTime.cs
 * Purpose: Definition of the Class Lekar.WorkTime
 ***********************************************************************/

using System;

namespace Model.Manager
{
    public class WorkPeriod
    {
        public WorkTime workTime;

        public System.DateTime BeginDate;
        public System.DateTime EndDate;
        private Shift Shift;

    }
}