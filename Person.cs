using System;

public class Class1
{
	public Class1()
	{

    public string Navn { get; set; }
    public int Alder { get; set; }

    public void SigHej()
    {
        Console.WriteLine($"Hej, jeg hedder {Navn} og er {Alder} år.");
    }
}
}
// Her kommer login-funktionen