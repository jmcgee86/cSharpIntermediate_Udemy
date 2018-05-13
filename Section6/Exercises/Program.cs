using System;
using System.Collections;
using System.Collections.Generic;


namespace Exercises_Interfaces
{
    public class WorkflowEngine
    {

        //private readonly Workflow _workflow
        private readonly IList<IActivity> _activities;


        public WorkflowEngine()
        {
            _activities = new List<IActivity>();
        }

         public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public void RunActivities()
        {
            foreach(var activity in _activities)
            {
                activity.Execute();
            }
        }
    }

        public interface IActivity
        {
            void Execute();
        }

        public class Upload : IActivity
        {
            public void Execute()
            {
                System.Console.WriteLine("uploading video");
            }
        }
        
        public class CallEncoding : IActivity
        {
            public void Execute()
            {
                System.Console.WriteLine("Calling video encoding service");
            }
        }

        public class MessageOwner : IActivity
        {
            public void Execute()
            {
                System.Console.WriteLine("messaging owner of video");
            }
        }

        public class ChangeStatus : IActivity
        {
            public void Execute()
            {
                System.Console.WriteLine("Video status = processing");
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.AddActivity(new Upload());
            workflowEngine.AddActivity(new CallEncoding());
            workflowEngine.AddActivity(new MessageOwner());
            workflowEngine.AddActivity(new ChangeStatus());

            workflowEngine.RunActivities();


        }
    }
}
