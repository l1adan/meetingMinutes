using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Meeting_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("--------------------------* MEETING MINUTES MANAGEMENT *------------------------"); //Meeting Title
            Console.WriteLine();


            Console.WriteLine("What would you like to do? Please enter the number of the option you'd like to \nexecute below to proceed.");
            Console.WriteLine();

            //Menu options
            string createMeetingItem = "1. Create Meeting";
            string viewTeamItem = "2. View Team";
            string exitItem = "3. Exit";

            Console.WriteLine(createMeetingItem);               //users menu
            Console.WriteLine(viewTeamItem);
            Console.WriteLine(exitItem);

            executingMenu();

            List<string> meetingTypes = new List<string>();

            meetingTypes.Add("Fire Type");
            meetingTypes.Add("Water Type");
            meetingTypes.Add("Psycich Type");

            for(int i = 0; i < meetingTypes.Count; i++)
            {
                Console.WriteLine(i + 1 + ": " + meetingTypes[i]);
            }
            
           
            



        }

        static void executingMenu()
        {
            string userMinuteRecorder;
            string userTeamLeader;
            string userMeetingDate;
            int userMeetingType;
            string usersMeetingType;
            string userMeetingTopic;
            string topicNotes;
            int extraTopicNotesResponse;

            


            string userMenuSelection = (Console.ReadLine());

            switch (userMenuSelection)
            {

                case "1":
                    Console.WriteLine("                               CREATE MEETING");
                    Console.WriteLine("Please enter the team members name who'll be recording the minutes of your \nmeeting:");      //Minute Recorder
                    userMinuteRecorder = Console.ReadLine();

                    Console.WriteLine("Please enter the leaders name of the meeting:");            //Team Leader
                    userTeamLeader = Console.ReadLine();

                    Console.WriteLine("Please enter the desired date of the meeting.(MM/DD/YY)"); //Meeting Date
                    userMeetingDate = Console.ReadLine();


                    Console.WriteLine("What type of meeting will this be?");

                    List<string> meetingTypes = new List<string>(); // shitty list

                    meetingTypes.Add("Fire Type");
                    meetingTypes.Add("Water Type");
                    meetingTypes.Add("Psycich Type");

                    for (int i = 0; i < meetingTypes.Count; i++)
                    {
                        Console.WriteLine(i + 1 + ": " + meetingTypes[i]);
                    }

                    userMeetingType = int.Parse(Console.ReadLine());

                    if (userMeetingType == 1)
                    {
                        usersMeetingType = "Fire Type";
                    }
                    else if (userMeetingType == 2)
                    {
                        usersMeetingType = "Water Type";
                    }
                    else if (userMeetingType == 3)
                    {
                        usersMeetingType = "Psycich Type";
                    }

                    Console.WriteLine("Enter the topic of your meeting:");      //meeting topic
                    userMeetingTopic = Console.ReadLine();

                    Console.WriteLine("Enter any notes you may have about the topic below"); // topic notes
                    topicNotes = Console.ReadLine();

                    Console.WriteLine("Would you like to enter notes for another topic? \n");
                    extraTopicNotesResponse = int.Parse(Console.ReadLine());










                    break;



                    }

           
                    
            
        }



    }
}
