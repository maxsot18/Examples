Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 1;
int ya = 1;
int xb = 30;
int yb = 1;
int xc = 15;
int yc = 1;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(yc, xc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 33)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb);
    }
    if(what == 2)
    {
        x = (x + xc);
        y = (y + yc);
    } 
   
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+"); 
    count++;
}    