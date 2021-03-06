﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class DetailsOfTravel
    {
        public DetailsOfTravel(int travelCode,string collectionOrDispersing,string destinationOrSource,TimeSpan hour,string frequency,DateTime dateOfBegin,DateTime dateOfEnd, string groupName, double latitude, double longitude)
        {
            this.travelCode = travelCode;
            this.collectionOrDispersing = collectionOrDispersing;
            this.destinationOrSource = destinationOrSource;
            this.hour = hour;
            this.frequency = frequency;
            this.dateOfBegin = dateOfBegin;
            this.dateOfEnd = dateOfEnd;
            this.groupName = groupName;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public double Longitude { get; set; }

        public double Latitude { get; set; }
        private int travelCode;

        public int TravelCode
        {
            get { return travelCode; }
            set { travelCode = value; }
        }
        private string collectionOrDispersing;

        public string CollectionOrDispersing
        {
            get { return collectionOrDispersing; }
            set { collectionOrDispersing = value; }
        }
        private string destinationOrSource;

        public string DestinationOrSource
        {
            get { return destinationOrSource; }
            set { destinationOrSource = value; }
        }
        private TimeSpan hour;

        public TimeSpan Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private string frequency;

        public string Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        private DateTime dateOfBegin;

        public DateTime DateOfBegin
        {
            get { return dateOfBegin; }
            set { dateOfBegin = value; }
        }
        private DateTime dateOfEnd;

        public DateTime DateOfEnd
        {
            get { return dateOfEnd; }
            set { dateOfEnd = value; }
        }
        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }
    }
}
