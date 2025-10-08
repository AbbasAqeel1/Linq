using System;
using Shared;



namespace LinqTut15
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            //RunDistinctAndDistinctBy();
            RunExcetp();
            RunIntersect();
            RunUnion();
            Console.ReadKey();
        }

        /// <summary>
        /// brings the elements that exists in set1 and set2 without repeat duplicates 
        /// </summary>
        private static void RunUnion()
        {

            Console.WriteLine("\n\n--------------------------------");
            Console.WriteLine("    Union Method    ");
            Console.WriteLine("--------------------------------\n");

            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"\nMeeting 1 participatns {set1.Count}");
            set2.Print($"\nMeeting 2 participatns {set2.Count}");

            var set3 = set1.Union(set2);

            set3.Print($"Meeting 1 Union Meeting 2 ({set3.Count()})");


            var set4 = set1.UnionBy(set2,x => x.EmployeeNo);

            set4.Print($"Meeting 1 set1.UnionBy(set2,x => x.EmployeeNo) Meeting 2 ({set4.Count()})");
        }

        private static void RunIntersect()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"\nMeeting 1 participatns ({set1.Count})");
            set2.Print($"\nMeeting 2 participatns ({set2.Count})");

            var set3 = set1.Intersect(set2);

            set3.Print($"\nMeeting1 participants Intersect Meeting2 participants ({set3.Count()})");


            var set4 = set1.IntersectBy(set2.Select(x => x.EmployeeNo), x => x.EmployeeNo);

            set4.Print($"\nMeeting1 participants IntersectBy (set2.Select(x => x.EmployeeNo), x => x.EmployeeNo) ({set4.Count()})");


        }

        private static void RunExcetp()
        {
            var set1 = Repository.Meeting1.Participants;
            var set2 = Repository.Meeting2.Participants;

            set1.Print($"\nMeeting 1 participatns ({set1.Count})");
            set2.Print($"\nMeeting 2 participatns ({set2.Count})");

            var set3 = set1.Except(set2);

            set3.Print($"\nMeeting1 participants except Meeting2 participants ({set3.Count()})");


            var set4 = set1.ExceptBy(set2.Select(x => x.EmployeeNo), x => x.EmployeeNo);

            set4.Print($"\nMeeting1 participants exceptBy (set2.Select(x => x.EmployeeNo), x => x.EmployeeNo) ({set3.Count()})");




        }

        private static void RunDistinctAndDistinctBy()
        {
            var ParticipantsM1M2 = Repository.Meeting1.Participants.Concat(Repository.Meeting2.Participants);

            ParticipantsM1M2.Print("Meeting 1 and Meeting 2 participants");

            var DistinctParticipantsOfM1andM2UsingDistinct = ParticipantsM1M2.Distinct();
            DistinctParticipantsOfM1andM2UsingDistinct.Print("Meeting 1 and Meeting 2 participants using distinct()");


            var DistinctParticipantsOfM1andM2UsingDistinctBy = ParticipantsM1M2.DistinctBy(x => x.EmployeeNo);
            DistinctParticipantsOfM1andM2UsingDistinctBy.Print("Meeting 1 and Meeting 2 participants using distinctBy(x => x.EmployeeNo)");
            
        }
    }

}