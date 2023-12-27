

class HardKBK
{
    public string Name { get; set; }
    public int EnrolledStudents { get; set; }
    public int Graduates { get; set; }

    public virtual double Quality()
    {
        return (double)Graduates / EnrolledStudents;
    }
}


class Level1 : HardKBK
{
    public override double Quality()
    {
        return base.Quality();
    }
}


class Level2 : HardKBK
{
    public double EmploymentRate { get; set; }

    public override double Quality()
    {
        return EmploymentRate * base.Quality();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Level1 institution1 = new Level1()
        {
            Name = "Университет 1",
            EnrolledStudents = 1000,
            Graduates = 900
        };

        Level2 institution2 = new Level2()
        {
            Name = "Университет 2",
            EnrolledStudents = 800,
            Graduates = 400,
            EmploymentRate = 0.75
        };


        Console.WriteLine("Качество учебного заведения 1: " + institution1.Quality());
        Console.WriteLine("Качество учебного заведения 2: " + institution2.Quality());

        Console.ReadLine();
    }
}