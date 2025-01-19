int days = int.Parse(Console.ReadLine());  // the interval we need to calculate wether the doctors are enough or not 

int doctors = 7;

int treatedPatients = 0;
int untreatedPatients = 0;


for (int  i  = 1;  i  <= days;  i ++)
{ 

    if (treatedPatients < untreatedPatients && i % 3 == 0)
    {
        doctors++;
    }

    int patientsPerDay = int.Parse(Console.ReadLine());

    if (patientsPerDay <= doctors)
    {
        treatedPatients += patientsPerDay;
    }
    else
    {
        treatedPatients += doctors;
        untreatedPatients += patientsPerDay - doctors;
    }


}

Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");