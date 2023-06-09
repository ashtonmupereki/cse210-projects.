class Roller
{
    private int counter;

    public Roller()
    {
        counter = 0;
    }

     public void ShowRoller()
     {
         counter++;
         switch (counter % 4)
         {
             case 0:
                 Console.Write(".");
                 break;
             case 1:
                 Console.Write(".");
                 break;
             case 2:
                 Console.Write(".");
                 break;
             case 3:
                 Console.Write(".");
                 break;
             default:
                 break;
         }
         Thread.Sleep(100);
         string blank = new string('\b', 1);  // Overwrite character
         Console.Write(blank);
     }

     public void ShowRollerReady()
     {
         Console.WriteLine("Get ready...");
         for (int i = 0; i < 3; i++)
         {
             ShowRoller();
         }
     }

     public void ShowRollerDone()
     {
         Console.WriteLine("Done!");
         for (int i = 0; i < 3; i++)
         {
             ShowRoller();
         }
     }
}