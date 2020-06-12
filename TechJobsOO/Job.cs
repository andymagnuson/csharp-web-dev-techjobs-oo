using System;
using System.Collections.Generic;
using System.Linq;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; } = "";
        public Employer EmployerName { get; set; } = new Employer();
        public Location EmployerLocation { get; set; } = new Location();
        public PositionType JobType { get; set; } = new PositionType();
        public CoreCompetency JobCoreCompetency { get; set; } = new CoreCompetency();


        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {                        
            string nameTemp= "" ;
           List<string> valuesList = new List<string> {Id.ToString(), Name, EmployerName.Value, EmployerLocation.Value,JobType.Value, JobCoreCompetency.Value};
            List<string> newValuesList = new List<string>();
            List<string> displayList = new List<string> { "ID:", "Name:", "Employer:", "Location:", "Position Type:", "Core Competency:" };
            string test = String.Join("", valuesList.ToArray());
            if (test.Trim().ToString() == Id.ToString())
            {
                return "\nOOPS! This job does not seem to exist.";
            }
           
            foreach (string value in valuesList)
            {
                if (value == "" || value == null)
                {
                    newValuesList.Add("Data not available");
                }
                else
                {
                    newValuesList.Add(value);
                }
            }
            var result = newValuesList.Zip(displayList, (a, b) => new {
                test1 = a,
                test2 = b
            });
            foreach (var item in result)
            {
                nameTemp = nameTemp + "\n" +item.test2 + " " + item.test1;
            }
            return nameTemp;
            }
        }       
    }

