﻿namespace AssignmentOne.Models
{
    public class Studentdata
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string myAdd { get; set; }
        public string myEmail { get; set; }
        public int myPhone { get; set; }
        public string myGender { get; set; }
        public string myTech { get; set; }
        //public int mySubmitDate { get; set; }

        public DateTime mySubmitTime { get; set; } = DateTime.Now;


        
    }
}
