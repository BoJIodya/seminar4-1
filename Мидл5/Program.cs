int a = 98547254;
//int result = (int)Math.Log10(a) + 1; //просто считает кол-во цифр

int Method(int a) // считает сколько цифр в числе и их сумму, через остаток от деления
{
    int count = 0;
    int result = a;
    int proizveden = 0;
    while (result > 0) 
    {
        proizveden = proizveden + (result % 10); // переменная так названа, потому что сначала считал произведение, но суть та же
        result = result / 10;
        count++;
    }
    return proizveden;
}

int met = Method(a);
Console.WriteLine(met);