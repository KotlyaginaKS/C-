// Особое приветствие
Console.Write("Введите имя пользователя: ");
 string username = Console.ReadLine();

 if (username.ToLower() == "паша")
 {
    Console.WriteLine("Ура, это же ПАША!");
 }
 else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);
 }