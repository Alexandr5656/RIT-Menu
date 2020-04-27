using System;
using System.Drawing;

namespace EventsLib
{
    public class Event
    {

        public string name;
        public string type;
        public string description;
        public string imageURL;

        public DateTime startTime;
        public DateTime endTime;

        //Constructor function
        public Event(string name, string type, string description, DateTime start, DateTime end, string imageURL = null)
        {
            this.update(name, type, description, start, end);
        }

        private bool setName(string name)
        {

            //add some validation here if necessary
            this.name = name;
            return true;

        }

        private bool setType(string type)
        {

            //add some validation here if necessary
            this.type = type;
            return true;

        }

        private bool setDescription(string description)
        {

            //add some validation here if necessary
            this.description = description;
            return true;

        }

        private bool setImageURL(string imageURL)
        {

            this.imageURL = imageURL;
            return true;

        }

        private bool setTime(DateTime startTime, DateTime endTime)
        {

            //check if the endTime is after the startTime
            //if (DateTime.Compare(endTime, startTime) < 0)
            //{
            this.startTime = startTime;
            this.endTime = endTime;
            return true;
            //}
            //else
            //{
            //Throw an exception to be handled by the error handler
            //throw new System.Exception("Your event start time has to be before than your end time.");
            //}

        }

        public bool update(string name, string type, string description, DateTime start, DateTime end, string imageURL = null)
        {

            try
            {
                if (name != null)
                    this.setName(name);
                if (type != null)
                    this.setType(type);
                if (description != null)
                    this.setDescription(description);
                this.setTime((start != null ? start : this.startTime), (end != null ? end : this.endTime));
                if (imageURL != null)
                    this.setImageURL(imageURL);
                return true;
            }
            catch (Exception theError)
            {
                //TODO: find better way to handle this once everything gets going
                Console.WriteLine($"An error occured: {theError}");
                return false;
            }
        }

    }
}
