using MetodosCRUD_SolisAndrade.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //agregarEstudiante();
        //consultarEstudiantes();
        //consultarEstudiante();
        //modificarEstudiante();
        //eliminarEstudiante();
        //consultarEstudiantesFunciones();
    }

    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli.clienteID = 1;
        cli.nombre = "Janeor";
        cli.apellido = "Loor";
        cli.direccion = "Coop. 5 de Junio";
        cli.telefono = "0959317272";
        cli.fechaNacimiento = "11/09/2001";
        cli.estado = true;
        context.Clientes.Add(cli);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cli.clienteID + " " + cli.nombre + " " + cli.apellido);
    }

    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar cliente");
        ClienteContext context = new ClienteContext();
        List<Cliente> listClientes = context.Clientes.ToList();
        foreach (var cli in listClientes)
        {
            Console.WriteLine("Codigo: " + cli.clienteID + " " + cli.nombre + " " + cli.apellido);
        }
    }

    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);
        Console.WriteLine("Codigo: " + cli.clienteID + " " + cli.nombre + " " + cli.apellido);
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);
        cli.nombre = "Paulo";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cli.clienteID + " " + cli.nombre + " " + cli.apellido);
    }


    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar cliente");
        ClienteContext context = new ClienteContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);
        context.Remove(cli);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cli.clienteID + " " + cli.nombre + " " + cli.apellido);
    }

    public static void consultarEstudiantesFunciones()
    {
        Console.WriteLine("Metodo consultar estudiantes con el uso de funciones");
        ClienteContext context = new ClienteContext();
        List<Cliente> listClientes;

        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente cli = context.Clientes.First();

        Console.WriteLine("Primer elemento de la tabla:" + cli.clienteID + "-" + cli.nombre);

        listClientes = context.Clientes.Where(s => s.nombre.StartsWith("P")).ToList();

        foreach (var clie in listClientes)
        {
            Console.WriteLine("Codigo: " + clie.clienteID + " " + clie.nombre + " " + clie.apellido);
        }
    }
}