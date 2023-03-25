using System.Globalization;

void adivinar()
{
    const int oportunidades = 4;
    int numerousuario;
    byte intentos, bandera;
    string linea;

    Random random = new Random();
    int randomNumber = random.Next(1,21);
    intentos = 1;
    bandera = 0;

    do
    {
        Console.WriteLine("Estoy pensando un numero cual sera ");
        linea= Console.ReadLine();
        numerousuario= Convert.ToInt32(linea);
        if (randomNumber==numerousuario)
        {
            Console.WriteLine("Adivinaste");
            bandera = 1;
        }
        else
        {
            if (numerousuario>randomNumber)
            {
                Console.WriteLine("---EL NUMERO ES MAYOR---");
            }
            else
            {
                Console.WriteLine("---EL NUMERO ES MENOR---");
            }
            intentos++;
        }
        
    } while (((intentos <= oportunidades) & (bandera == 0)));
}




void mayor_menor()
{
    int mayor = 0;
    int menor = 10;
    int numero = 0;

    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        numero =random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor= numero;
        }
        if(numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine($"El mayor es: {mayor}");
    Console.WriteLine($"El menor es: { menor}");

}

void catcher()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese una cantidad : ");
    try
    {
        cantidad= int.Parse(Console.ReadLine());
        cantidad = cantidad / 0;
    }catch(FormatException fox)
    {
        Console.WriteLine("Ingreso mal el numero.. " + fox.Message) ;

    }
    catch (Exception ex)
    {
        Console.WriteLine("Hay un error de otro tipo.. " + ex.Message);
    }
    if (cantidad> 0)
    {
        Console.WriteLine("Cantidad ingresada "+cantidad) ;
    }
}

void ejemplo()
{
    int[] numero = new int[7];
    int suma = 0;

    numero[0] = 45;
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 79;
    numero[4] = 86;
    numero[5] = 92; ;
    numero[6] = 69;
    int elementos =numero.Length;

    string[] nombres = new string[elementos];   

    for(int i = 0;i < elementos; i++)
    {
        suma += numero[i];
        Console.WriteLine(numero[i]);
    }

    Console.WriteLine($"Sumatoria {suma}");
    Console.WriteLine($"El promedio es: {suma/elementos}");
}

void ejemplo1()
{
    int elementos = 10;
    string[] nombres = new string[elementos];
    int[] j = new int[2];
    nombres[0] = "juan";
    nombres[1] = "flor";
    nombres[2] = "jose";
    nombres[3] = "javier";
    nombres[4] = "maria";
    nombres[5] = "henry";
    nombres[6] = "eduardo";
    nombres[7] = "fabian";
    nombres[8] = "luis";
    nombres[9] = "josue";

    for (int i = 1; i <= 2; i++)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 10);
        j[i - 1] = randomNumber;
    }
    int r = j[0];
    int rr= j[1];
    Console.WriteLine($"El que gano la pierna de cerdo fue {nombres[r]}");
    Console.WriteLine($"El segundo premio es para {nombres[rr]}");
}

ejemplo1(); 


