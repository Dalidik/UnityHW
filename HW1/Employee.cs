class Employee : Person
{
    public Employee (string name, int Age, string Job, string Language)
public string Job {get; set;}
 public Employee (string job)
 {
 Job = job;
 }
 
public string Language {get; set;}
public Employee(string language)
{
 Language = language;
}


    public override void SolveProblem()
    {
       Console.WriteLine ($"{Name} work as {Job}");
    }

    public override void Print()
 {
  Console.WriteLine($"{Name} have {Age},work like {Job} and speak {Language}");
 }


}