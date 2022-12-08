int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 34;
int c1 = 25;
int a2 = 6542;
int b2 = 94;
int c2 = 77;
int a3 = 86;
int b3 = 246;
int c3 = 743;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);