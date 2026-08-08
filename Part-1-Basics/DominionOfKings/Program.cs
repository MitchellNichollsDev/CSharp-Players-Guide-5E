Console.WriteLine("How Many Estates do you have?");
string numberOfEstatesText = Console.ReadLine();

Console.WriteLine("How Many Duchies do you have?");
string numberOfDuchiesText = Console.ReadLine();

Console.WriteLine("How Many Provinces do you have?");
string numberOfProvincesText = Console.ReadLine();

// Converting Estates, Duchies and Provinces into ints for calculation from strings
int numberOfEstates = Convert.ToInt32(numberOfEstatesText);
int numberOfDuchies = Convert.ToInt32(numberOfDuchiesText);
int numberOfProvinces = Convert.ToInt32(numberOfProvincesText);

// Total Score with calculations equated for point allocation (Estates: 1, Duchies: 3, Provinces: 6)
int usersScore = (numberOfEstates * 1) + (numberOfDuchies * 3) + (numberOfProvinces * 6);

Console.WriteLine($"Your Total Score is: {usersScore}");