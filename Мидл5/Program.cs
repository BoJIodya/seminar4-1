int a = 12312;
//int result = (int)Math.Log10(a) + 1; //просто считает кол-во цифр

int Method(int a) // считает сколько цифр в числе и произведение, через остаток от деления
{
    int count = 0;
    int result = a;
    int proizveden = 1;
    while (result > 0) // если в числе будет 0, то произведение будет = 0, не зависимо от кол-ва цифр 
    {
        proizveden = proizveden * (result % 10);
        result = result / 10;
        count++;
    }
    return proizveden;
}

int met = Method(a);
Console.WriteLine(met);