// Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Cristiano Ronaldo", 7);

// ronaldo.Display();

Player roger = new Player("Roger Federer", 8);

// roger.Display();

Team team1 = new Team("team 1");

team1.AddPlayer(ronaldo);
team1.AddPlayer(roger);

team1.DisplayRoster();
