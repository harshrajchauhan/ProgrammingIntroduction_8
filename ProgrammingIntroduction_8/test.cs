using System;
 
// Base Class
class School
{
    // Properties
    public string Name { get; set; }
    public string Principal { get; set; }
    public int StudentCount { get; set; }
 
    // Constructor
    public School(string name, string principal, int studentCount)
    {
        Name = name;
        Principal = principal;
        StudentCount = studentCount;
    }
 
    // Method to display school info
    public virtual string DisplayInfo()
    {
        return $"School Name: {Name}, Principal: {Principal}, Student Count: {StudentCount}";
    }
}
 
// Derived Class 1: MiddleSchool
class MiddleSchool : School
{
    // Properties specific to MiddleSchool
    public int LowestGrade { get; set; }
    public int HighestGrade { get; set; }
 
    // Constructor
    public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
        : base(name, principal, studentCount) // Call base class constructor
    {
        LowestGrade = lowestGrade;
        HighestGrade = highestGrade;
    }
 
    // Override the DisplayInfo method
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Lowest Grade: {LowestGrade}, Highest Grade: {HighestGrade}";
    }
}
 
// Derived Class 2: HighSchool
class HighSchool : School
{
    // Property specific to HighSchool
    public string SportsFieldName { get; set; }
 
    // Constructor
    public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
        : base(name, principal, studentCount) // Call base class constructor
    {
        SportsFieldName = sportsFieldName;
    }
 
    // Override the DisplayInfo method
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Sports Field Name: {SportsFieldName}";
    }
}
 
// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Creating a MiddleSchool object
        MiddleSchool middleSchool = new MiddleSchool("Green Valley Middle School", "Mr. Smith", 500, 6, 8);
        Console.WriteLine(middleSchool.DisplayInfo());
 
        // Creating a HighSchool object
        HighSchool highSchool = new HighSchool("Hillside High School", "Mrs. Johnson", 1200, "Eagles Field");
        Console.WriteLine(highSchool.DisplayInfo());
    }
}
 