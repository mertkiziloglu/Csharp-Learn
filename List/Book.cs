using System.Collections.Generic;

namespace PluralSight
{
    public class Book
    {
        
        
        public Book()
        {
            grades=new List<double>();
            this.name = name;
        }
        
        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public List<double> grades;
      string name;
    }
}