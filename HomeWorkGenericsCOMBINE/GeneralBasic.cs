using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGenericsCOMBINE
{
    class GeneralBasic
    {
        public int Id { get; set; }
    }
    class student : GeneralBasic
    {
        public override string ToString()
        {
            return "student";
        }
    }
    class Course : GeneralBasic
    {
        public override string ToString()
        {
            return "Course";
        }
    }
    class AllGeneral <T> where T : GeneralBasic ,new()
    {
        //AllGeneral<student> AllStudent = new AllGeneral<student>();
        //AllGeneral<Course> Courses = new AllGeneral<Course>();


        public string Everything()
        {
            return ToString();
        }

        //public T Shows { get; set; }
        //public AllGeneral()
        //{
        //    Shows = new T();
        //}
    }
}
