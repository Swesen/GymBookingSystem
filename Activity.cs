using System;
using System.Collections.Generic;

namespace GymBookingSystem
{
    internal class Activity
    {
        public string Title;
        public string Description;
        public DateTime StartDate { private set; get; }
        public DateTime EndDate { private set; get; }
        public int InstructorID;
        public int MaxParticipant { private set; get; }
        public string Locale { private set; get; }

        // list of participant id
        public List<int> Participants { private set; get; }

        // list of equipment id
        public List<int> Equipment { private set; get; }


        public Activity(string title, string description, DateTime startDate, DateTime endDate, int instructorID, int maxParticipant, string locale, List<int> participants, List<int> equipment)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            InstructorID = instructorID;
            MaxParticipant = maxParticipant;
            Locale = locale;
            Participants = participants;
            Equipment = equipment;
        }

        public Activity(string title, string description, DateTime startDate, DateTime endDate, int instructorID, int maxParticipant, string locale)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            InstructorID = instructorID;
            MaxParticipant = maxParticipant;
            Locale = locale;
            Participants = new List<int>();
            Equipment = new List<int>();
        }

        public void AddEquipment(int[] equipmentID)
        {
            for (int i = 0; i < equipmentID.Length; i++)
            {
                Participants.Add(equipmentID[i]);
            }
        }

        public void AddEquipment(int equipmentID)
        {
            Equipment.Add(equipmentID);
        }

        public void AddParticipant(int[] userID)
        {
            for (int i = 0; i < userID.Length; i++)
            {
                Participants.Add(userID[i]);
            }
        }

        public void AddParticipant(int userID)
        {
            Participants.Add(userID);
        }
    }
}