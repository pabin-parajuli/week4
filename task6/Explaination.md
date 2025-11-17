## Problem
The error happens because the program divides marks by total using integers. When two integers are divided in C#, the result is also an integer. This means any decimal value is removed completely.

Because of this, if you divide something like 45 by 50, the result becomes 0 instead of 0.9. After that, multiplying 0 by 100 still gives 0, so the percentage shown by the program is incorrect.

The program looks wrong even though the final answer is stored in a double. This is because the division happens first, and since both numbers are integers, the calculation is already incorrect before it gets stored.

## Fix 
To fix the issue, one of the numbers must be treated as a decimal number. When either marks or total is converted to a double, C# performs decimal division and gives the correct percentage.
