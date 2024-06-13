using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseVectors
{
    internal class Room
    {
        public int Number { get; set; }
        public bool HasStudent { get; private set; }
        public string? StudentName { get;  private set; }

        public Room(int number, bool hasStudent)
        {
            Number = number;
            HasStudent = false;
        }
        
        public Room(int number, bool hasStudent,string? studentName) : this(number, hasStudent)
        {
            StudentName = studentName;
        }

        public Room registerRoom(int number)
        {
            return this;
        }
        
        
    }
}
