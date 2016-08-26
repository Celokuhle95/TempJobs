using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempJobsWcf
{
    public class Invitation
    {
        private int jobID;
        private string name;
        private string description;
        private int numberOfDays;
        private string dueDate;
        private string startDate;
        private string startTime;
        private string endTime;
        private string location;
        private double toBePaid;
        private int employerID;
        private string employerFirstName;
        private string employerLastName;

        public int JobID
        {
            get
            {
                return jobID;
            }

            set
            {
                jobID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int NumberOfDays
        {
            get
            {
                return numberOfDays;
            }

            set
            {
                numberOfDays = value;
            }
        }

        public string DueDate
        {
            get
            {
                return dueDate;
            }

            set
            {
                dueDate = value;
            }
        }

        public string StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public string EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public double ToBePaid
        {
            get
            {
                return toBePaid;
            }

            set
            {
                toBePaid = value;
            }
        }

        public int EmployerID
        {
            get
            {
                return employerID;
            }

            set
            {
                employerID = value;
            }
        }

        public string EmployerFirstName
        {
            get
            {
                return employerFirstName;
            }

            set
            {
                employerFirstName = value;
            }
        }

        public string EmployerLastName
        {
            get
            {
                return employerLastName;
            }

            set
            {
                employerLastName = value;
            }
        }
    }
}