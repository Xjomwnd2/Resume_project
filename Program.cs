echo using System; > Program.cs
echo. >> Program.cs
echo class Program >> Program.cs
echo { >> Program.cs
echo     static void Main(string[] args) >> Program.cs
echo     { >> Program.cs
echo         // Create job instances >> Program.cs
echo         Job job1 = new Job(); >> Program.cs
echo         job1._company = "Microsoft"; >> Program.cs
echo         job1._jobTitle = "Software Engineer"; >> Program.cs
echo         job1._startYear = 2019; >> Program.cs
echo         job1._endYear = 2022; >> Program.cs
echo. >> Program.cs
echo         Job job2 = new Job(); >> Program.cs
echo         job2._company = "Apple"; >> Program.cs
echo         job2._jobTitle = "Manager"; >> Program.cs
echo         job2._startYear = 2022; >> Program.cs
echo         job2._endYear = 2023; >> Program.cs
echo. >> Program.cs
echo         // Create resume instance >> Program.cs
echo         Resume myResume = new Resume(); >> Program.cs
echo         myResume._name = "Allison Rose"; >> Program.cs
echo. >> Program.cs
echo         // Add jobs to resume >> Program.cs
echo         myResume._jobs.Add(job1); >> Program.cs
echo         myResume._jobs.Add(job2); >> Program.cs
echo. >> Program.cs
echo         // Display resume >> Program.cs
echo         myResume.Display(); >> Program.cs
echo     } >> Program.cs
echo } >> Program.cs