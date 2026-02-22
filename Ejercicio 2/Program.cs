Console.WriteLine("Hora: (0-23)");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Día: (1-7)");
int day = int.Parse(Console.ReadLine());
Console.WriteLine("ROL");
Console.WriteLine("1:Estudiante\n2:Docente\n3:Técnico IT\n4:Visitante");
Console.WriteLine("Ingrese opción:");
int option = int.Parse(Console.ReadLine());
if ((hora>=0 && hora<=23)&&(day>=0 && day<=7))
{
    switch (option)
    {
        case 1:
            {
                Console.WriteLine("¿Carnet vigente? 1:Si 2:No");
                int carnet = int.Parse(Console.ReadLine());
                if (carnet==1 && (hora>=7 && hora<=18))
                {
                    Console.WriteLine("Acceso permitido");
                }
                else if (carnet==2 && (hora>=7 && hora<=18))
                {
                    Console.WriteLine("¿Tiene autorización? 1:Si 2:No");
                    int autorizacion = int.Parse(Console.ReadLine());
                    if (autorizacion==1)
                    {
                        Console.WriteLine("Acceso permitido");
                    }
                    else if (autorizacion==2)
                    {
                        Console.WriteLine("Acceso denegado");
                    }
                }
                else if (hora<7 && hora>18)
                {
                    Console.WriteLine("¿Tiene autorización? 1:Si 2:No");
                    int sino1 = int.Parse(Console.ReadLine());
                    if (sino1==1)
                    {
                        Console.WriteLine("Acceso permitido");
                    }
                    else
                    {
                        Console.WriteLine("Acceso denegado");
                    }
                }
                break;
            }
    }
}