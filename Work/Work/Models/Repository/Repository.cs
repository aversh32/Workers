using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Work.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Worker> Workers
        {
            get { return context.Workers; }
        }

        public IEnumerable<Language> Language
        {
            get { return context.Language; }
        }
        public void SaveWorker(Worker worker)
        {
            if (worker.worker_id == 0)
            {
                worker = context.Workers.Add(worker);
            }
            else
            {
                Worker dbWorker = context.Workers.Find(worker.worker_id);
                if (dbWorker != null)
                {
                    dbWorker.Name = worker.Name;
                    dbWorker.Surname = worker.Surname;
                    dbWorker.Age = worker.Age;
                    dbWorker.department_id = worker.department_id;
                    dbWorker.lang_id = worker.lang_id;
                }
            }
            context.SaveChanges();
        }

        public void DeleteWorker(Worker worker)
        {
            context.Workers.Remove(worker);
            context.SaveChanges();
        }
    }
}