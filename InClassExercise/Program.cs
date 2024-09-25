public class School
{
    
    public string Name { 
        get;
        set; 
    }
    public string Principal { get; set; }
    public int StudentCount { get; set; }

    public School(string name, string principal, int studentCount)
    {
        Name = name;
        Principal = principal;
        StudentCount = studentCount;
    }
}


public class MiddleSchool : School
{
    public int LowestGrade { get; set; }
    public int HighestGrade { get; set; }

    public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
        : base(name, principal, studentCount) 
    {
        LowestGrade = lowestGrade;
        HighestGrade = highestGrade;
    }
}

public class HighSchool : School
{
    
    public string SportsFieldName { get; set; }

    public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
        : base(name, principal, studentCount) 
    {
        SportsFieldName = sportsFieldName;
    }
}

public class Exercise
{
    public static void Main()
    {
        MiddleSchool ms = new MiddleSchool("Vamsi Krishna", "Dr. Manish Agarwal", 500, 6, 8);
        Console.WriteLine($"Middle School: {ms.Name}, Principal: {ms.Principal}, Grades: {ms.LowestGrade}-{ms.HighestGrade}, Students: {ms.StudentCount}");

        HighSchool hs = new HighSchool("Akhil Goud", "Mrs. Johnson", 1000, "Pine Field");
        Console.WriteLine($"High School: {hs.Name}, Principal: {hs.Principal}, Sports Field: {hs.SportsFieldName}, Students: {hs.StudentCount}");
    }
}