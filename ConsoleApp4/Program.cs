Console.WriteLine("Введите строку");
string str = Convert.ToString(Console.ReadLine());
string[] words = str.Split(new char[] { ' ', ',' }) ;
int koll = words.Length - 1;
Console.WriteLine($"Количество слов равно {koll}") ;