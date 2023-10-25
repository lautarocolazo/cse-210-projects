Elevator el1 = new Elevator(1, 1, 30);

Console.WriteLine(el1.DisplayFloor());

Console.WriteLine(el1.ListFloors());

el1.ChangeFloor(5);

Console.WriteLine(el1.DisplayFloor());

Console.WriteLine(el1.GetDoorsOpen());

el1.OpenDoors();

Console.WriteLine(el1.GetDoorsOpen());

