﻿namespace ApiProjectKampi.WebApi.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string MapLocation { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string OpenHours { get; set; }
    }
}
