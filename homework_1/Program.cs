Console.WriteLine("\t\t\t\t\t\tEdedi daxil edin!");
int eded=Convert.ToInt32(Console.ReadLine());
int mertebe = 0;
int maks_mertebe = 0;
if (eded==0)
{
    Console.WriteLine("Maks mertebe : 0");
}
else
{
    while(eded!=0)
    {
        mertebe = eded % 10;
        if (mertebe>maks_mertebe)
        {
            maks_mertebe=mertebe;
        }
        eded=eded/10;
    }
    Console.WriteLine("Maks mertebe:" + "" + maks_mertebe);
      
}