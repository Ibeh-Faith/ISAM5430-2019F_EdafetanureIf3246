using System;
using System.Collections.Generic;
using System.Text;

namespace C2
{
    class Motorway
    {
        public enum IsToll
        {
            Yes,
            No,
            Na
        }
        public enum Directions
        {
            North, East, South, West, Na
        }
        public string Name { get; set; }
        public string MotorwayType { get; set; } = "na";
        public char Direction { get; set; }
        public string Surface { get; set; } = "na";
        public int NumberOfLanes { get; set; }
        public bool Toll { get; set; }
        public string Maintainance { get; set; } = "na";

        public Motorway(string name, string type, char direction, string surface, int numOfLanes, bool toll, string maint)
        {
            Name = name;
            MotorwayType = type;
            Direction = direction;
            Surface = surface;
            NumberOfLanes = numOfLanes;
            Toll = toll;
            Maintainance = maint;
        }
        public Motorway(string name)
        {
            Name = name;
        }
        public Motorway(string name, bool toll)
        {
            Name = name;
            Toll = toll;
        }
        public Motorway(string name, int numOfLanes)
        {
            Name = name;
            NumberOfLanes = numOfLanes;
        }
       
        public string NameOfMotorWay()
        {

            return Name;

        }
        public string NameToll()
        {

            return Name+","+Toll;

        }
        public string NameNoOfLanes()
        {

            return Name + "," +NumberOfLanes;

        }

        public override string ToString()
        {
            return $"Motorway Name: {Name}\n" +
                $"Motorway Type: {MotorwayType}\n" +
                $"Direction:{Direction}\n" +
                $"Surface: {Surface}\n" +
                $"Number Of Lanes: {NumberOfLanes}\n" +
                $"Toll: {Toll}\n" +
                $"Maintainance: {Maintainance}";
        }

    }
}
