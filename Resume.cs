echo using System; > Resume.cs
echo using System.Collections.Generic; >> Resume.cs
echo. >> Resume.cs
echo public class Resume >> Resume.cs
echo { >> Resume.cs
echo     public string _name; >> Resume.cs
echo     public List^<Job^> _jobs = new List^<Job^>(); >> Resume.cs
echo. >> Resume.cs
echo     public void Display() >> Resume.cs
echo     { >> Resume.cs
echo         Console.WriteLine($"Name: {_name}"); >> Resume.cs
echo         Console.WriteLine("Jobs:"); >> Resume.cs
echo. >> Resume.cs
echo         foreach (Job job in _jobs) >> Resume.cs
echo         { >> Resume.cs
echo             job.Display(); >> Resume.cs
echo         } >> Resume.cs
echo     } >> Resume.cs
echo } >> Resume.cs