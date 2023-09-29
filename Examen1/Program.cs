using Examen1;

Examen examen = new Examen();
/*Console.WriteLine("Ingrese un número de inicio");
int inicio = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un número final");
int final =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine(examen.Numeros(inicio, final)); */
Console.WriteLine("Ingresa una tabla del uno al diez");
int tabla = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(examen.Tablas(0, 10, tabla));