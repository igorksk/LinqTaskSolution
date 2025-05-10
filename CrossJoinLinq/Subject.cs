using System.Collections.Generic;

namespace CrossJoinLinq
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public static List<Subject> GetAllSubjects()
        {
            return
            [
                new Subject { ID = 1, SubjectName = "ASP.NET"},
                new Subject { ID = 2, SubjectName = "SQL Server" },
                new Subject { ID = 5, SubjectName = "Linq"}
            ];
        }
    }
}
