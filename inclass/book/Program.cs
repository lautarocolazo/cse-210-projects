Book bookTest = new Book("HP's Author", "Harry Potter");

bookTest.Display();
// Console.WriteLine(bookTest.IsAvailable());
Console.WriteLine(bookTest.TimesRead());
Console.WriteLine(bookTest.HasAuthor("Sanderson"));
bookTest.CheckOut();
Console.WriteLine(bookTest.TimesRead());
bookTest.CheckIn();
Console.WriteLine(bookTest.IsAvailable());

BookCase bookCase = new BookCase();

bookCase.AddBook(bookTest);
