Console.WriteLine("Въведете възраст:");
int age = int.Parse(Console.ReadLine());
if(age < 18)
{
    Console.WriteLine("Непълнолетен");
}
else if(age > 18)
{
    Console.WriteLine("Пълнолетен");
}