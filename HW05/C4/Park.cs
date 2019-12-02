using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    class Park
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string  TypeOfPark { get; set; }
        public string Facility { get; set; }
        public float Fee { get; set; }
        public int NumOfEmployees  { get; set; }
        public int NumOfVisitors  { get; set; }
        public float AnnualBudget { get; set; }
       

        public Park (string name, string location, string typeOfPark, string facility, float fee, int numOfEmployees,
            int numOfVisitors, float annualBudget)
        {
            Name = name;
            Location = location;
            TypeOfPark = typeOfPark;
            Facility = facility;
            Fee = fee;
            NumOfEmployees = numOfEmployees;
            NumOfVisitors = numOfVisitors;
            AnnualBudget = annualBudget;
         

        }
        public Park(String name, string location, string typeOfPark)
        {
            Name = name;
            Location = location;
            TypeOfPark = typeOfPark;
        }
       public Park(float fee)
        {
            Fee = fee;
        }

        public string NameLocType()
        {
          
            return Name+","+ Location + "," + TypeOfPark;
            
        }
        public string NameLocFacility()
        {
          
            return Name + "," + Location + "," + Facility;
        }
        
        public float CostVisitor()
        {
            return AnnualBudget / NumOfVisitors;
        }
        public float Revenue()
        {
            return AnnualBudget - (NumOfVisitors * Fee);
        }
        public override string ToString()
        {
            return $"Park Name: {Name}\n" +
                $"Park Location: {Location}\n" +
                $"Type Of Park:{TypeOfPark}\n" +
                $"Facilities Available:{Facility}\n" +
                $"Fee: ${Fee}\n" +
                $"Number Of Employees: {NumOfEmployees}\n" +
                $"Number Of Visitors in the past 12 Months: {NumOfVisitors}\n" +
                $"Annual Budget: ${AnnualBudget} per year\n";
                
     

            
        }
        

    }
    }

