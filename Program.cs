Console.WriteLine("\t\t\t\t\tAy ve gunu daxil edin!");
string ay = Console.ReadLine();
while (ay != "January" || ay != "January" || ay != "March" || ay != "April" || ay != "May" || ay != "June" || ay != "July" || ay != "August" || ay != "September" || ay != "October" || ay != "November" || ay != "December")
{
    if (ay == "January" || ay == "January" || ay == "March" || ay == "April" || ay == "May" || ay == "June" || ay == "July" || ay == "August" || ay == "September" || ay == "October" || ay == "November" || ay == "December") 
    {
        break;
    }
    Console.WriteLine("Ayi yeniden daxil edin!");
    ay = Console.ReadLine();

}
while (ay == "January" || ay == "January" || ay == "March" || ay == "April" || ay == "May" || ay == "June" || ay == "July" || ay == "August" || ay == "September" || ay == "October" || ay == "November" || ay == "December")

   
{   
    int gun = Convert.ToInt32(Console.ReadLine());
    while(ay == "January" || ay == "March" || ay == "May" || ay == "July" || ay == "August" || ay == "October" || ay == "December" && gun <0 && gun > 31)
    {
        if ( gun > 0 && gun <= 31)
        {
            Console.WriteLine(gun + " " + ay + " " + "tarixi ucun rezerv olundu");
            break;
        }
        else 
        {
            gun = Convert.ToInt32(Console.ReadLine());
        }
        
    }
    while(ay=="February")
    {
        if (gun > 0 && gun <= 29)
        {
            Console.WriteLine(gun + " " + ay + " " + "tarixi ucun rezerv olundu");
            break;
        }
        else
        {
            gun = Convert.ToInt32(Console.ReadLine());
        }

    }

    while(ay == "April" || ay == "June" || ay == "September" || ay=="Novamber")
    {
        if (gun > 0 && gun <= 30)
        {
            Console.WriteLine(gun + " " + ay + " " + "tarixi ucun rezerv olundu");
            break;
        }
        else
        {
            gun = Convert.ToInt32(Console.ReadLine());
        }
    }






}



