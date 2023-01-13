Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // как бы мы не записали слова с большой или с маленькой буквы теперь
//                                   оно писаться как мы зададим ниже 
//if(username == "Маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
} 

