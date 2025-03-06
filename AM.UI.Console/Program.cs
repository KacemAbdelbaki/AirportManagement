using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Plane plane1 = new Plane();
plane1.Capacity = 100;
plane1.ManufactureDate = DateTime.Now;
plane1.PlaneType = PlaneType.Boeing;
plane1.PlaneId = 1;
Console.WriteLine("Constructeur par défaut : " + plane1.ToString());
Plane plane2 = new Plane(PlaneType.Airbus, 50, DateTime.Now);
Console.WriteLine("Constructeur paramétré : " + plane2.ToString());
Plane plane3 = new Plane(); 
Console.WriteLine("Initialisateur d'objet : " + plane3.ToString());
Plane plane4 = new Plane { };
Console.WriteLine("Initialisateur d'objet vide : " + plane4.ToString());
// using initialisation from now no more constructeur 
Passenger passenger = new Passenger { fullName = new FullName { FirstName = "Kacem", LastName = "Abdelbaki" }, EmailAddress = "a@b.c", PassportNumber= "Pass123" };
Console.WriteLine(passenger.ToString());
Console.WriteLine(passenger.CheckProfile("Kacem", "Abdelbaki") + "\n");
Console.WriteLine(passenger.CheckProfile("Kacem", "not") + "\n");
Console.WriteLine(passenger.CheckProfile("Kacem", "Abdelbaki", "a@b.c") + "\n");
Console.WriteLine(" CHeck with mail : \n " + passenger.CheckProfileComplete("Kacem", "Abdelbaki", "a@b.c") + "\n");
Console.WriteLine(" CHeck without mail : \n " + passenger.CheckProfileComplete("Kacem", "Abdelbaki") + "\n");
Staff staff = new Staff { fullName = new FullName { FirstName = "Staff", LastName = "Abdelbaki" }, Function = "staff" };
Traveller traveller = new Traveller { fullName = new FullName { FirstName = "Traveller", LastName = "Abdelbaki" }, Nationality = "tunisian" };
Console.WriteLine(staff.ToString());
staff.PassengerType();
Console.WriteLine(traveller.ToString());
traveller.PassengerType();

// td 2 ;
FlightMethods fm = new FlightMethods { flights = TestData.listFlights };
string destination = "Paris";
Console.WriteLine(" List Dates de la destination " + destination + "  : \n ");
List<DateTime> list = new List<DateTime> { };
list = (List<DateTime>)fm.GetFlightDates(destination);
// using foreach loop
foreach (DateTime d in list)
{
    Console.WriteLine(" Flight Date : " + d);
}

// Question 10
Console.WriteLine("\nQuestion 10 :");
fm.ShowFlightDetails(TestData.Airbusplane);
fm.ShowFlightDetails(TestData.BoingPlane);

// Question 11
Console.WriteLine("\nQuestion 11 :");
Console.WriteLine(fm.ProgrammedFlightNumber(new DateTime(2022, 01, 01, 10, 10, 10)));

// Question 12
Console.WriteLine("\nQuestion 12 :");
Console.WriteLine(fm.DurationAverage(TestData.flight4.Destination));

// Question 13
Console.WriteLine("\nQuestion 13 :");
foreach (var f in fm.OrderedDurationFlights())
{
    Console.WriteLine(f);
}

// Question 14
Console.WriteLine("\nQuestion 14 :");
foreach(var f in fm.SeniorTravellers(fm.flights[0]))
{
    Console.WriteLine(f);
}

// Question 15
Console.WriteLine("\nQuestion 15 :");
fm.DestinationGroupedFlights();

// Question 16
Console.WriteLine("\nQuestion 16 :");
Console.WriteLine("Flight details without delegate :\n");
fm.ShowFlightDetails(TestData.BoingPlane);
Console.WriteLine("Flight details with delegate :\n");
fm.FlightDetailsDel(TestData.BoingPlane);


// Question 20
Console.WriteLine("\nQuestion 20 :");
Passenger passenger20 = new Passenger { fullName = new FullName { FirstName = "kaCeM", LastName = "abdElBaKi" }, EmailAddress = "a@b.c" };
Console.WriteLine("Before extension");
Console.WriteLine(passenger20.ToString());
Console.WriteLine("After extension");
passenger20.UpperFullName();
Console.WriteLine(passenger20.ToString());


// Partie 3: Entity Framework Core
AMContext context = new AMContext();
context.Flights.Add(TestData.flight2);
context.SaveChanges();
Console.WriteLine("Flight added to database");
