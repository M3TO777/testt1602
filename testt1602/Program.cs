Console.WriteLine("Въведете възраст:");
int age = int.Parse(Console.ReadLine());

switch(age)
{
    case < 18:
        Console.WriteLine("Непълнолетен");
        break;
    case > 18:
        Console.WriteLine("Пълнолетен");
        break;
}