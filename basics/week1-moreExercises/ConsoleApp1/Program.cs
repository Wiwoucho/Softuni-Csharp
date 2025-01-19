double degrees = double.Parse(Console.ReadLine());

if (degrees > 25.9)
{ Console.WriteLine("Hot"); }

else if (degrees > 20)
{ Console.WriteLine("Warm"); }

else if (degrees > 14.9)
{ Console.WriteLine("Mild"); }

else if (degrees > 11.9)
{ Console.WriteLine("Cool"); }

else if (degrees > 4.9)
{ Console.WriteLine("Cold"); }

else
{ Console.WriteLine("nknown"); }



