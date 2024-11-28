// disena un programa que permita al usuario ingresar 5 productos y sus respectivos precios uno por uno, luego el programa debe: mostrar el nombre del producto y el precio del producto mas caro , calcular el precio total de todos los productos.


float precio_total=0;
string[] productos = new string[5];
float[] precios = new float[5];
float precio, precio_mascaro =0;
string  producto_mascaro ="";

for (int i = 0; i < productos.Length; i++)
{
    System.Console.WriteLine($"INGRESA EL PRODUCTO {i+1}:");
    productos[i] = Console.ReadLine()!;
}
Console.Clear();
for (int i = 0; i < precios.Length; i++)
{
    System.Console.WriteLine($"Precio de {productos[i]}");
    precios[i] =Convert.ToSingle(Console.ReadLine());
}

for (int i = 0; i < precios.Length; i++)
{
    precio = precios[i];
    if (precio_mascaro < precio)
    {
        precio_mascaro = precio;
        producto_mascaro = productos[i];
    }
}

for (int i = 0; i < precios.Length; i++)
{
    precio_total += precios.Sum();
}

System.Console.WriteLine($"EL PRECIO MAS ELEVADO ES : {precio_mascaro}");
System.Console.WriteLine($"EL PRODUCTO MAS CARO ES  : {producto_mascaro}");
System.Console.WriteLine($"EL PRECIO TOTAL ES :{precio_total}");



