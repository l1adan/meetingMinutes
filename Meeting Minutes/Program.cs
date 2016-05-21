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

        //CREATING A MEETING SWITCH CASE METHOD
        {
            executingMenu();
        }

       


        static void MeetingMinutesMenu()
        {
            //Program Header and Menu
            Console.WriteLine("                      -----------------------------------");
            Console.WriteLine("-------------------(* MEETING MINUTES MANAGEMENT SOFTWARE *)--------------------");
            Console.WriteLine("                      -----------------------------------");
            Console.WriteLine();


            Console.WriteLine("Please enter the number of the option you'd like to execute below to proceed.");
            Console.WriteLine();

            //MENU OPTIONS

            string createMeetingItem = "1. Create Meeting";
            string viewTeamItem = "2. View Team";
            string exitItem = "3. Exit";

            Console.WriteLine(createMeetingItem);
            Console.WriteLine(viewTeamItem);
            Console.WriteLine(exitItem);
        }

        //Switch Case Variables
        static void executingMenu()
        {
            string fileName;
            string userMinuteRecorder;
            string userTeamLeader;
            string userMeetingDate;
            int userMeetingType;
            string usersMeetingType;
            string topicNotes = "";
            string extraNotes = "";
            string extraTopicNotesResponse = "";
            string userMeetingTopic = "";

            //CASE 2 VARIABLES
            string userTeamResponse;
            int waterTeam = 1;
            int fireTeam = 2;
            int psychicTeam = 3;

            MeetingMinutesMenu();




            string userMenuSelection = (Console.ReadLine());

            switch (userMenuSelection)
            {

                case "1":
                    Console.WriteLine("                               CREATE MEETING");
                    Console.WriteLine();
                    Console.WriteLine("Please enter the team members name who'll be recording the minutes of your \nmeeting:");      //Minute Recorder
                    userMinuteRecorder = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Please enter the name of the human you've appointed to lead your meeting:");            //Team Leader
                    userTeamLeader = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Please enter the desired date of the meeting.(MMDDYY)"); //Meeting Date
                    userMeetingDate = Console.ReadLine();
                    Console.WriteLine();


                    Console.WriteLine("What type of meeting will this be? \nSelect the number of your desired meeting type:");

                    List<string> meetingTypes = new List<string>(); // List

                    meetingTypes.Add("Fire Type");
                    meetingTypes.Add("Water Type");
                    meetingTypes.Add("Psychic Type");

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
                        usersMeetingType = "Psychic Type";
                    }

                    Console.WriteLine("Enter the topic of your meeting:");      //meeting topic
                    userMeetingTopic = Console.ReadLine();

                    Console.WriteLine("Enter any notes you may have about the topic below:"); // topic notes
                    topicNotes = Console.ReadLine();

                    Console.WriteLine("Would you like to enter notes for another topic?");
                    Console.WriteLine("If so write (YES) if not write (NO)");
                    extraTopicNotesResponse = Console.ReadLine().ToUpper();

                    List<string> additionalTopic = new List<string>();
                    List<string> additionalNotes = new List<string>();


                    //EXTRA TOPIC LOOP
                    while (extraTopicNotesResponse == "YES")
                    {
                        Console.WriteLine("Enter the topic of your meeting:");
                        string extraTopic = Console.ReadLine();
                        additionalTopic.Add(extraTopic);
                        Console.WriteLine("Enter any notes you may have about the topic below:");
                        extraNotes = Console.ReadLine();
                        additionalNotes.Add(extraNotes);
                        Console.WriteLine("Would you like to enter notes for another topic?\nIf so, write: (YES) if not write: (NO):");
                        extraTopicNotesResponse = Console.ReadLine().ToUpper();

                    }
                    //STREAM WRITER
                    fileName = "Minutes" + userMeetingDate + ".txt";
                    StreamWriter writer = new StreamWriter(fileName);

                    using (writer)
                    {
                        writer.WriteLine("Date:" + userMeetingDate);
                        writer.WriteLine("PokeMart");
                        writer.WriteLine("630 Masselin Ave. \nPallet Town, SomeWhere in Pokemon Land 10000");
                        writer.WriteLine();
                        writer.WriteLine();

                        writer.WriteLine("Minutes Recorder: " + userMinuteRecorder);
                        writer.WriteLine();
                        writer.WriteLine("Meeting Leader: " + userTeamLeader);
                        writer.WriteLine();
                        writer.WriteLine("Meeting Type: " + userMeetingType);
                        writer.WriteLine();
                        writer.WriteLine("Meeting Topic: " + userMeetingTopic);
                        writer.WriteLine();
                        writer.WriteLine("Notes: " + topicNotes);

                        for (int i = 0; i < additionalNotes.Count; i++)
                        {
                            writer.WriteLine("Topic: " + additionalTopic[i]);
                            writer.WriteLine("Notes: " + additionalNotes[i]);
                        }
                    }
                        StreamReader reader = new StreamReader(fileName);

                    using (reader)
                        {

                            string text = reader.ReadToEnd();
                            Console.WriteLine(text);
                        }


                   executingMenu();


                    break;


                case "2":

                     waterTeam = 1;
                     fireTeam = 2;
                     psychicTeam = 3;

                //LIST OF TEAMS   
                List<string> pokeTeams = new List<string>();
                    {
                        pokeTeams.Add("Water Team");
                        pokeTeams.Add("Fire Team");
                        pokeTeams.Add("Psychic Team");
                    }


                    //TEAM MEMBERS
                    Dictionary<string, string> team = new Dictionary<string, string>();

                    team.Add("Squirtle", "Water Team");
                    team.Add("Lapras", "Water Team");
                    team.Add("Seadra", "Water Team");

                    team.Add("Charizard", "Fire Team");
                    team.Add("Nine Tails", "Fire Team");
                    team.Add("Charmander", "Fire Team");

                    team.Add("Alakazam", "Psychic Team");
                    team.Add("Mr. Mime", "Psychic Team");
                    team.Add("Drowsie",  "Psychic Team");

                    Console.WriteLine();

                    Console.WriteLine("Select the number of the team you'd like to view:");
                    Console.WriteLine();

                    Console.WriteLine("1. Water Team");
                    Console.WriteLine("2. Fire Team");
                    Console.WriteLine("3. Psychic Team");
                    Console.WriteLine("4. View All Teams and Members:");

                    userTeamResponse = (Console.ReadLine());

                    if (userTeamResponse == "1") // VEIW WATER TEAM
                    {
                        foreach (KeyValuePair<string, string> pokemon in team)
                        {
                            if (pokemon.Value == "Water Team")
                            {
                                Console.WriteLine(pokemon.Key);
                            }
                        }

                    }

                    else if (userTeamResponse == "2") //VIEW FIRE TEAM
                    {
                        foreach (KeyValuePair<string, string> pokemon in team)
                        {
                            if (pokemon.Value == "Fire Team")
                            {
                                Console.WriteLine(pokemon.Key);
                            }
                        }

                    }

                    else if (userTeamResponse == "3") // PSYCHIC TEAM 
                    {
                        foreach (KeyValuePair<string, string> pokemon in team)
                        {
                            if (pokemon.Value == "Psychic Team")
                            {
                                Console.WriteLine(pokemon.Key);
                            }
                        }

                    }

                    
                    //   VIEW ALL TEAM MEMBERS
                    else if (userTeamResponse == "4")
                    {
                        foreach (KeyValuePair<string, string> pokemon in team)
                        {
                            Console.WriteLine(pokemon.Key +" ("+ pokemon.Value+")");
                        }

                    }

                    else
                    {
                        Console.WriteLine("Invalid response. Please enter a number in range of teams listed:");
                        userTeamResponse = Console.ReadLine();
                    }

                    executingMenu();
                    break;


                //EXITS PROGRAM
                case "3":
                    exit();
                    break;

                  
                    

                default:
                    Console.WriteLine();
                    Console.WriteLine("                                INVALID RESPONSE");
                    executingMenu();
                    break;

            }

         }

     static void exit()
        {
            Console.WriteLine("                         \a \a \a ~ ~ ~ * GOOD BYE! * ~ ~ ~");
            Environment.Exit(0);
        }

    }
}
