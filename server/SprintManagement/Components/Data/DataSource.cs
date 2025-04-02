using System.ComponentModel.DataAnnotations;

namespace Sprint_Management.Components.Data
{
    public class SprintManagmentModel
    {
        public static int MaxId = 0;

        public static Dictionary<int, List<TaskInfoModel>> SprintPlans = new Dictionary<int, List<TaskInfoModel>>()
        {
            { 1, ProjectCollection1() },
            { 2, ProjectCollection2() },
            { 3, ProjectCollection3() }
        };

        public static Dictionary<int, List<AssignmentModel>> AssignmentCollections = new Dictionary<int, List<AssignmentModel>>()
        {
            { 1, ProjectAssignmentCollection1() },
            { 2, ProjectAssignmentCollection2() },
            { 3, ProjectAssignmentCollection3() }
        };

        public class SprintModel
        {
            public List<TaskInfoModel> ProjectCollection { get; set; }
            public List<AssignmentModel> ResourceAssignmentCollection { get; set; }
        }

        public class TaskInfoModel
        {
            public int Id { get; set; }
            [Required]
            public string? Subject { get; set; } = String.Empty;
            [Required]
            [CustomValidation]
            public string? Status { get; set; } = String.Empty;
            [Required]
            public DateTime? StartTime { get; set; }
            [Required]
            public DateTime? EndTime { get; set; }
            [Required]
            public string? Priority { get; set; } = String.Empty;
            public List<ResourceInfoModel>? Resources { get; set; }
            public List<string>? Tags { get; set; }
            public string? ClassName { get; set; } = String.Empty;
            [Required]
            public string? Assignee { get; set; } = String.Empty;
            [Required]
            [CustomValidation]
            [Range(0, 100, ErrorMessage = "Progress value cannot be greater than 100")]
            public int Progress { get; set; }
            public string Predecessor { get; set; } = String.Empty;
            public string? Color { get; set; } = String.Empty;
            public int? ParentId { get; set; }
        }

        public class ResourceInfoModel
        {
            public int ResourceId { get; set; }
            public string? ResourceName { get; set; }
            public double Unit { get; set; }
        }

        public class AssignmentModel
        {
            public int PrimaryId { get; set; }
            public int TaskId { get; set; }
            public int ResourceId { get; set; }
            public double Unit { get; set; }
        }

        public static List<ResourceInfoModel> ResourcesCollection = new List<ResourceInfoModel>()
        {
            new ResourceInfoModel() { ResourceId= 1, ResourceName= "Martin Tamer" },
            new ResourceInfoModel() { ResourceId= 2, ResourceName= "Rose Fuller" },
            new ResourceInfoModel() { ResourceId= 3, ResourceName= "Margaret Buchanan" },
            new ResourceInfoModel() { ResourceId= 4, ResourceName= "Fuller King" },
            new ResourceInfoModel() { ResourceId= 5, ResourceName= "Davolio Fuller" },
        };

        public static List<AssignmentModel> ProjectAssignmentCollection1()
        {
            List<AssignmentModel> resourceAssignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ PrimaryId=1, TaskId = 1 , ResourceId=1},
                new AssignmentModel(){ PrimaryId=2, TaskId = 2 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=3, TaskId = 3 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=4, TaskId = 4 , ResourceId=1},
                new AssignmentModel(){ PrimaryId=5, TaskId = 5 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=6, TaskId = 6 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=7, TaskId = 7, ResourceId=2},
                new AssignmentModel(){ PrimaryId=8, TaskId = 8 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=9, TaskId = 9, ResourceId=5},
                new AssignmentModel(){ PrimaryId=10, TaskId = 10 , ResourceId=5},
                new AssignmentModel(){ PrimaryId=11, TaskId = 11, ResourceId=1},
                new AssignmentModel(){ PrimaryId=12, TaskId = 12, ResourceId=1},
                new AssignmentModel(){ PrimaryId=13, TaskId = 13, ResourceId=4},
                new AssignmentModel(){ PrimaryId=14, TaskId = 14, ResourceId=4},
                new AssignmentModel(){ PrimaryId=15, TaskId = 15, ResourceId=3},
                new AssignmentModel(){ PrimaryId=16, TaskId = 16, ResourceId=3},
                new AssignmentModel(){ PrimaryId=17, TaskId = 17, ResourceId=5},
                new AssignmentModel(){ PrimaryId=18, TaskId = 18, ResourceId=5},
                new AssignmentModel(){ PrimaryId=19, TaskId = 19, ResourceId=5},
                new AssignmentModel(){ PrimaryId=20, TaskId = 20, ResourceId=2},
                new AssignmentModel(){ PrimaryId=21, TaskId = 21, ResourceId=5},
                new AssignmentModel(){ PrimaryId=22, TaskId = 22, ResourceId=1},
                new AssignmentModel(){ PrimaryId=23, TaskId = 23, ResourceId=2},
                new AssignmentModel(){ PrimaryId=24, TaskId = 24, ResourceId=1}
            };
            return resourceAssignments;
        }

        public static List<AssignmentModel> ProjectAssignmentCollection2()
        {
            List<AssignmentModel> resourceAssignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ PrimaryId=1, TaskId = 1 , ResourceId=1},
                new AssignmentModel(){ PrimaryId=2, TaskId = 2 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=3, TaskId = 3 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=4, TaskId = 4 , ResourceId=1},
                new AssignmentModel(){ PrimaryId=5, TaskId = 5 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=6, TaskId = 6 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=7, TaskId = 7, ResourceId=1},
                new AssignmentModel(){ PrimaryId=8, TaskId = 8 , ResourceId=5},
                new AssignmentModel(){ PrimaryId=9, TaskId = 9, ResourceId=4},
                new AssignmentModel(){ PrimaryId=10, TaskId = 10 , ResourceId=4},
                new AssignmentModel(){ PrimaryId=11, TaskId = 11, ResourceId=4},
                new AssignmentModel(){ PrimaryId=12, TaskId = 12, ResourceId=5},
                new AssignmentModel(){ PrimaryId=13, TaskId = 13, ResourceId=2},
                new AssignmentModel(){ PrimaryId=14, TaskId = 14, ResourceId=1},
                new AssignmentModel(){ PrimaryId=15, TaskId = 15, ResourceId=4},
                new AssignmentModel(){ PrimaryId=16, TaskId = 16, ResourceId=4},
                new AssignmentModel(){ PrimaryId=17, TaskId = 17, ResourceId=5},
                new AssignmentModel(){ PrimaryId=18, TaskId = 18, ResourceId=2},
                new AssignmentModel(){ PrimaryId=19, TaskId = 19, ResourceId=4},
                new AssignmentModel(){ PrimaryId=20, TaskId = 20, ResourceId=1}
           };
            return resourceAssignments;
        }

        public static List<AssignmentModel> ProjectAssignmentCollection3()
        {
            List<AssignmentModel> resourceAssignments = new List<AssignmentModel>()
            {
                new AssignmentModel(){ PrimaryId=1, TaskId = 1 , ResourceId=1},
                new AssignmentModel(){ PrimaryId=2, TaskId = 2 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=3, TaskId = 3 , ResourceId=2},
                new AssignmentModel(){ PrimaryId=4, TaskId = 4 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=5, TaskId = 5 , ResourceId=3},
                new AssignmentModel(){ PrimaryId=6, TaskId = 6 , ResourceId=5},
                new AssignmentModel(){ PrimaryId=7, TaskId = 7, ResourceId=5},
                new AssignmentModel(){ PrimaryId=8, TaskId = 8 , ResourceId=5},
                new AssignmentModel(){ PrimaryId=9, TaskId = 9, ResourceId=2},
                new AssignmentModel(){ PrimaryId=10, TaskId = 10, ResourceId=2}
            };
            return resourceAssignments;
        }

        public static List<TaskInfoModel> ProjectCollection1()
        {
            List<TaskInfoModel> Tasks = new List<TaskInfoModel>()
            {
                new TaskInfoModel(){
                    Id = 1,
                    Subject = "Implement User Authentication",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,05,08,30,00,000,DateTimeKind.Utc),
                    Assignee = "Martin Tamer",
                    Priority= "High",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 40,
                    ClassName = "e-martintamer",
                    Color = "#c9a7f4"
                },
                new TaskInfoModel(){
                    Id = 2,
                    Subject = "Design Database Schema",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,04,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 80,
                    Predecessor ="1",
                    ClassName = "e-rosefuller",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 3,
                    Subject = "Homepage UI Development",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,08,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 0,
                    Predecessor ="1",
                    ClassName = "e-margaretbuchanan",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 4,
                    Subject = "Homepage Redesign",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,08,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 0,
                    ClassName = "e-martintamer",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 5,
                    Subject = "API Integration with External Services",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,08 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Breaking Issue" },
                    Progress= 90,
                    ClassName = "e-rosefuller",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 6,
                    Subject = "Bug Fixing and Quality Assurance",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Internal Request" },
                    Progress= 100,
                    ClassName = "e-rosefuller",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 7,
                    Subject = "User Profile Management",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,14 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 90,
                    ClassName = "e-margaretbuchanan",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 8,
                    Subject = "Mobile App Compatibility Testing",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Bug", "Internal Request" },
                    Progress= 0,
                    ClassName = "e-fullerking",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 9,
                    Subject = "Performance Optimization",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,03 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,06, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug", "Breaking Issue" },
                    Progress= 67,
                    ClassName = "e-davoliofuller",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 10,
                    Subject = "Payment Gateway Integration",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,02 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 0,
                    ClassName = "e-davoliofuller",
                    Color="#c2dcf0",
                    Predecessor="5",
                },
                new TaskInfoModel(){
                    Id = 11,
                    Subject = "Cross-Browser Compatibility Testing",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,09 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug", "Breaking Issue" },
                    Progress= 40,
                    ClassName = "e-martintamer",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 12,
                    Subject = "Enhance User Notifications",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug", "Breaking Issue" },
                    Progress= 90,
                    ClassName = "e-martintamer",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 13,
                    Subject = "Implement Single Sign-On (SSO)",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 0,
                    ClassName = "e-fullerking",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 14,
                    Subject = "Implement Chat Feature",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Bug", "Internal Request" },
                    Progress= 55,
                    ClassName = "e-fullerking",
                    Color="#c9a7f4",
                    Predecessor="11",
                },
                new TaskInfoModel(){
                    Id = 15,
                    Subject = "Data Migration to New Server",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 56,
                    ClassName = "e-margaretbuchanan",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 16,
                    Subject = "User Feedback Analysis",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,06 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,08, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 100,
                    ClassName = "e-margaretbuchanan",
                    Color="#b6d6ab",
                    Predecessor="15"
                },
                new TaskInfoModel(){
                    Id = 17,
                    Subject = "Server Infrastructure Upgrades",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,12 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 100,
                    ClassName = "e-davoliofuller",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 18,
                    Subject = "Enhance Dashboard UI",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,02 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 0,
                    ClassName = "e-davoliofuller",
                    Color="#c2dcf0",
                    Predecessor="17",
                },
                new TaskInfoModel(){
                    Id = 19,
                    Subject = "Documentation and User Guides",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 0,
                    ClassName = "e-davoliofuller",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 20,
                    Subject = "Localization Support for Multiple Languages",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,08 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 100,
                    ClassName = "e-rosefuller",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 21,
                    Subject = "User Profile Customization Options",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 100,
                    ClassName = "e-davoliofuller",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 22,
                    Subject = "Third-Party API Integration",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug", "Customer Task" },
                    Progress= 100,
                    ClassName = "e-martintamer",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 23,
                    Subject = "User Onboarding and Tutorial Creation",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,10 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug" },
                    Progress= 56,
                    ClassName = "e-rosefuller",
                    Color="#f4daa8",
                    Predecessor = "22",
                },
                new TaskInfoModel(){
                    Id = 24,
                    Subject = "Implement Two-Factor Authentication (2FA)",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug" },
                    Progress= 56,
                    ClassName = "e-rosefuller",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 25,
                    Subject = "Performance Monitoring and Load Testing",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15, 08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug" },
                    Progress= 90,
                    ClassName = "e-martintamer",
                    Color="#f4daa8",
                    Predecessor="19"
                },
            };
            return Tasks;
        }
        public static List<TaskInfoModel> ProjectCollection2()
        {
            List<TaskInfoModel> Tasks = new List<TaskInfoModel>()
            {
                new TaskInfoModel(){
                    Id = 1,
                    Subject = "Database Backup and Recovery Strategy",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Assignee = "Martin Tamer",
                    Priority= "High",
                    Tags= new List<string>{"Validation"},
                    Progress= 0,
                    ClassName = "e-martintamer",
                    Color = "#c2dcf0"
                },
                new TaskInfoModel(){
                    Id = 2,
                    Subject = "User Profile Avatar Customization",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 20,
                    Predecessor ="1",
                    ClassName = "e-rosefuller",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 3,
                    Subject = "Integrate Machine Learning Algorithms",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"CR" },
                    Progress= 30,
                    ClassName = "e-margaretbuchanan",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 4,
                    Subject = "Implement User Feedback Surveys",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,05,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug" },
                    Progress= 100,
                    ClassName = "e-martintamer",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 5,
                    Subject = "Dashboard Widget Customization",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Validation" },
                    Progress= 0,
                    ClassName = "e-margaretbuchanan",
                    Color="#c2dcf0",
                    Predecessor="1",
                },
                new TaskInfoModel(){
                    Id = 6,
                    Subject = "User Engagement Analytics",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug" },
                    Progress= 60,
                    ClassName = "e-rosefuller",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 7,
                    Subject = "Multi-Platform Compatibility Testing",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,08,08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug" },
                    Progress= 70,
                    ClassName = "e-martintamer",
                    Color="#f4daa8",
                    Predecessor="4"
                },
                new TaskInfoModel(){
                    Id = 8,
                    Subject = "User Profile Data Export Feature",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug" },
                    Progress= 100,
                    ClassName = "e-davaliofuller",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 9,
                    Subject = "Performance Benchmarking and Optimization",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Testing" },
                    Progress= 0,
                    ClassName = "e-fullerking",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 10,
                    Subject = "Automated Error Logging and Reporting",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,08 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,14,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Bug" },
                    Progress= 100,
                    ClassName = "e-fullerking",
                    Color="#b6d6ab",
                    Predecessor="5",
                },
                new TaskInfoModel(){
                    Id = 11,
                    Subject = "User Activity Heatmaps",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,06 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,09,08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Bug" },
                    Progress= 20,
                    ClassName = "e-fullerking",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 12,
                    Subject = "Implement Dark Mode Theme",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Internal Request" },
                    Progress= 0,
                    ClassName = "e-davoliofuller",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 13,
                    Subject = "Database Replication and Scaling",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug" },
                    Progress= 40,
                    ClassName = "e-rosefuller",
                    Color="#c9a7f4",
                    Predecessor="10",
                },
                new TaskInfoModel(){
                    Id = 14,
                    Subject = "Enhanced Search Functionality",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Feature" },
                    Progress= 100,
                    ClassName = "e-martintamer",
                    Color="#b6d6ab",
                    Predecessor="10",
                },
                new TaskInfoModel(){
                    Id = 15,
                    Subject = "User Password Policy Management",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Feature" },
                    Progress= 0,
                    ClassName = "e-fullerking",
                    Color="#c2dcf0",
                    Predecessor="11",
                },
                new TaskInfoModel(){
                    Id = 16,
                    Subject = "Data Anonymization for Privacy",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Feature" },
                    Progress= 70,
                    ClassName = "e-fullerking",
                    Color="#c9a7f4",
                    Predecessor="15",
                },
                new TaskInfoModel(){
                    Id = 17,
                    Subject = "Interactive User Tutorials",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug","Internal Request" },
                    Progress= 80,
                    ClassName = "e-davoliofuller",
                    Color="#f4daa8",
                    Predecessor="15",
                },
                new TaskInfoModel(){
                    Id = 18,
                    Subject = "Real-time Collaboration Tools",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12,08,30,00,000,DateTimeKind.Utc),
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Customer Task" },
                    Progress= 0,
                    ClassName = "e-rosefuller",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 19,
                    Subject = "User Data Archiving and Cleanup",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Fuller King",
                    Tags= new List<string>{"Customer Task" },
                    Progress= 100,
                    ClassName = "e-fullerking",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 20,
                    Subject = "Implement File Upload and Sharing",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Martin Tamer",
                    Tags= new List<string>{"Bug","Customer Task" },
                    Progress= 100,
                    ClassName = "e-martintamer",
                    Color="#b6d6ab",
                    Predecessor="19",
                },

            };
            return Tasks;
        }
        public static List<TaskInfoModel> ProjectCollection3()
        {
            List<TaskInfoModel> Tasks = new List<TaskInfoModel>()
            {
                new TaskInfoModel(){
                    Id = 1,
                    Subject = "User Account Deletion Feature",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Assignee = "Martin Tamer",
                    Priority= "Low",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 0,
                    ClassName = "e-martintamer",
                    Color = "#c2dcf0"
                },
                new TaskInfoModel(){
                    Id = 2,
                    Subject = "Task Scheduling and Reminders",
                    Status= "In Progress",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 20,
                    ClassName = "e-rosefuller",
                    Color="#c9a7f4",
                },
                new TaskInfoModel(){
                    Id = 3,
                    Subject = "Advanced Data Analytics Dashboard",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,10 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12,08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug", "Release Bug" },
                    Progress= 30,
                    ClassName = "e-rosefuller",
                    Color="#f4daa8",
                    Predecessor="1",
                },
                new TaskInfoModel(){
                    Id = 4,
                    Subject = "User Access Control Management",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,11 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Company" },
                    Progress= 100,
                    ClassName = "e-margaretbuchanan",
                    Color="#b6d6ab",
                },
                new TaskInfoModel(){
                    Id = 5,
                    Subject = "Data Import and Export Tools",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,12 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,13,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Margaret Buchanan",
                    Tags= new List<string>{"Customer Task" },
                    Progress= 0,
                    ClassName = "e-margaretbuchanan",
                    Color="#c2dcf0",
                    Predecessor="1",
                },
                new TaskInfoModel(){
                    Id = 6,
                    Subject = "Notification System Overhaul",
                    Status= "Open",
                    StartTime= new DateTime( 2021,01,10 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Normal",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Internal Request" },
                    Progress= 0,
                    ClassName = "e-davoliofuller",
                    Color="#c2dcf0",
                },
                new TaskInfoModel(){
                    Id = 7,
                    Subject = "User Role-Based Permissions",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15,08,30,00,000,DateTimeKind.Utc),
                    Priority= "High",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Bug" },
                    Progress= 100,
                    ClassName = "e-davoliofuller",
                    Color="#b6d6ab",
                    Predecessor="5",
                },
                new TaskInfoModel(){
                    Id = 8,
                    Subject = "Server Performance Optimization",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,05 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,15,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Davolio Fuller",
                    Tags= new List<string>{"Internal Request" },
                    Progress= 80,
                    ClassName = "e-davoliofuller",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 9,
                    Subject = "Integration with Cloud Services",
                    Status= "Testing",
                    StartTime= new DateTime( 2021,01,10 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,12,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Low",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Customer Task" },
                    Progress= 90,
                    ClassName = "e-rosefuller",
                    Color="#f4daa8",
                },
                new TaskInfoModel(){
                    Id = 10,
                    Subject = "Real-time Chat and Messaging",
                    Status= "Done",
                    StartTime= new DateTime( 2021,01,01 , 06,30,00,000,DateTimeKind.Utc),
                    EndTime= new DateTime(2021,01,10,08,30,00,000,DateTimeKind.Utc),
                    Priority= "Critical",
                    Assignee ="Rose Fuller",
                    Tags= new List<string>{"Bug","Customer Task" },
                    Progress= 100,
                    ClassName = "e-rosefuller",
                    Color="#b6d6ab",
                    Predecessor="8",
                }
            };
            return Tasks;
        }
    }

    public class CustomValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var taskData = (SprintManagmentModel.TaskInfoModel)validationContext.ObjectInstance;

            if (taskData.Progress == 100 && taskData.Status != "Done")
            {
                return new ValidationResult("Status must be Done when Progress is 100.");
            }
            if (taskData.Status == "Done" && taskData.Progress != 100)
            {
                return new ValidationResult("Progress must be 100 when Status is Done.");
            }
            if (taskData.Progress == 0 && taskData.Status != "Open")
            {
                return new ValidationResult("Status must be Open when Progress is 0.");
            }
            if (taskData.Status == "Open" && taskData.Progress != 0)
            {
                return new ValidationResult("Progress must be 0 when Status is Open.");
            }
            return ValidationResult.Success;
        }
    }
}