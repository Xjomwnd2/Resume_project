echo using System; > Job.cs
echo. >> Job.cs
echo public class Job { >> Job.cs
echo     public string _jobTitle; >> Job.cs
echo     public string _company; >> Job.cs
echo     public int _startYear; >> Job.cs
echo     public int _endYear; >> Job.cs
echo. >> Job.cs
echo     public void Display() >> Job.cs
echo     { >> Job.cs
echo         Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}"); >> Job.cs
echo     } >> Job.cs
echo } >> Job.cs