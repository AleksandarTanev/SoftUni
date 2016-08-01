namespace _04.WorkForce.Models
{
    using System;
    using System.Collections.Generic;

    public class JobCollection
    {
        private readonly List<Job> collection;
        private List<Job> jobsToBeRemoved;

        public JobCollection()
        {
            this.collection = new List<Job>();
            this.jobsToBeRemoved = new List<Job>();
        }
       
        public void AddJob(Job newJob)
        {
            this.collection.Add(newJob);
            newJob.IsFinished += JobIsDone;
        }

        public void Update()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                this.collection[i].Update();
            }
            RemoveJobsFromCollection();
        }

        private void JobIsDone(object sender, EventArgs e)
        {
            var job = (Job) sender;
            job.IsFinished -= JobIsDone;

            Console.WriteLine($"Job {job.Name} done!");
            this.jobsToBeRemoved.Add(job);
        }

        private void RemoveJobsFromCollection()
        {
            foreach (var job in this.jobsToBeRemoved)
            {
                this.collection.Remove(job);
            }

            this.jobsToBeRemoved.Clear();
        }

        public void PrintStatus()
        {
            foreach (var job in this.collection)
            {
                Console.WriteLine(job);
            }
        }
    }
}
