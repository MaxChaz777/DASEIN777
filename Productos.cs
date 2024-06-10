using System;

class Producto
{
    private string codigo;
    private string nombre;
    private double precio;
    private int stock;

    // Constructor sin parámetros
    public Producto()
    {
        codigo = "Indefinido";
        nombre = "Indefinido";
        precio = 0.0;
        stock = 0;
    }

    // Constructor con parámetros
    public Producto(string codigo, string nombre)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = 0.0;
        this.stock = 0;
    }

    // Métodos para obtener las propiedades
    public string GetCodigo()
    {
        return codigo;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public double GetPrecio()
    {
        return precio;
    }

    public int GetStock()
    {
        return stock;
    }

    // Métodos para establecer las propiedades
    public void SetPrecio(double precio)
    {
        if (precio >= 0)
        {
            this.precio = precio;
        }
        else
        {
            Console.WriteLine("El precio no puede ser negativo.");
        }
    }

    public void SetStock(int stock)
    {
        if (stock >= 0)
        {
            this.stock = stock;
        }
        else
        {
            Console.WriteLine("El stock no puede ser negativo.");
        }
    }

    // Método para vender productos
    public void Vender(int cantidad)
    {
        if (cantidad > 0 && cantidad <= stock)
        {
            stock -= cantidad;
            Console.WriteLine($"Se han vendido {cantidad} unidades de {nombre}. Stock actual: {stock}");
        }
        else
        {
            Console.WriteLine("Cantidad no válida para la venta.");
        }
    }

    // Método para comprar productos
    public void Comprar(int cantidad)
    {
        if (cantidad > 0)
        {
            stock += cantidad;
            Console.WriteLine($"Se han comprado {cantidad} unidades de {nombre}. Stock actual: {stock}");
        }
        else
        {
            Console.WriteLine("Cantidad no válida para la compra.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Producto producto1 = new Producto();
        Producto producto2 = new Producto("CSDA", "eeee");

        Console.WriteLine("Ingrese el precio del primer producto:");
        double precio1 = Convert.ToDouble(Console.ReadLine());
        producto1.SetPrecio(precio1);

        Console.WriteLine("Ingrese el stock del primer producto:");
        int stock1 = Convert.ToInt32(Console.ReadLine());
        producto1.SetStock(stock1);

        Console.WriteLine("Ingrese el precio del segundo producto:");
        double precio2 = Convert.ToDouble(Console.ReadLine());
        producto2.SetPrecio(precio2);

        Console.WriteLine("Ingrese el stock del segundo producto:");
        int stock2 = Convert.ToInt32(Console.ReadLine());
        producto2.SetStock(stock2);

        Console.WriteLine("\nDatos iniciales del primer producto:");
        Console.WriteLine($"Código: {producto1.GetCodigo()}, Nombre: {producto1.GetNombre()}, Precio: {producto1.GetPrecio()}, Stock: {producto1.GetStock()}");

        Console.WriteLine("\nDatos iniciales del segundo producto:");
        Console.WriteLine($"Código: {producto2.GetCodigo()}, Nombre: {producto2.GetNombre()}, Precio: {producto2.GetPrecio()}, Stock: {producto2.GetStock()}");

        Console.WriteLine("\nIngrese la cantidad a vender del primer producto:");
        int cantidadVenta1 = Convert.ToInt32(Console.ReadLine());
        producto1.Vender(cantidadVenta1);

        Console.WriteLine("Ingrese la cantidad a comprar del primer producto:");
        int cantidadCompra1 = Convert.ToInt32(Console.ReadLine());
        producto1.Comprar(cantidadCompra1);

        Console.WriteLine("\nIngrese la cantidad a vender del segundo producto:");
        int cantidadVenta2 = Convert.ToInt32(Console.ReadLine());
        producto2.Vender(cantidadVenta2);

        Console.WriteLine("Ingrese la cantidad a comprar del segundo producto:");
        int cantidadCompra2 = Convert.ToInt32(Console.ReadLine());
        producto2.Comprar(cantidadCompra2);

        Console.WriteLine("\nDatos finales del primer producto:");
        Console.WriteLine($"Código: {producto1.GetCodigo()}, Nombre: {producto1.GetNombre()}, Precio: {producto1.GetPrecio()}, Stock: {producto1.GetStock()}");

        Console.WriteLine("\nDatos finales del segundo producto:");
        Console.WriteLine($"Código: {producto2.GetCodigo()}, Nombre: {producto2.GetNombre()}, Precio: {producto2.GetPrecio()}, Stock: {producto2.GetStock()}");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
