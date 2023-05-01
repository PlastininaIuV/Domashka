//Задача 10

Console.Write("вводим число a:  ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000) {
    a1  =  a  %  100/10; 
    Console.WriteLine ($" центральное число - { a1 }");
}
else{
    Console.WriteLine ( " Недопустимое значение! " );   
}  
