using System;

public class Parameter
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Prabin Parajuli";   // put your real full name here
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
