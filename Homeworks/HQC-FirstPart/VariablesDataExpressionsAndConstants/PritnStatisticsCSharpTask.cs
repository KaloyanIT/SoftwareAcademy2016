public void PrintStatistics(double[] array, int count)
{
    double max, tmp;
    for (int index = 0; index < count; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
    }

    PrintMax(max);
    tmp = 0;
    max = 0;

    for (int index = 0; index < count; index++)
    {
        if (array[index] < max)
        {
            max = array[index];
        }
    }

    PrintMin(max);

    tmp = 0;
    for (int index = 0; index < count; index++)
    {
        tmp += array[index];
    }

    PrintAvg(tmp/count);
}