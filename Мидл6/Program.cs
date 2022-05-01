int a = 123456789;

int lengh = (int)Math.Log10(a) + 1;

int i = 0;
while (i < lengh)
{

    int A = a / 10;
    i++;
    Console.WriteLine (A);

}
