﻿using EjercicioPotenciación;
using System;
using System.Data;

class Program
{
    static void Main()
    {
        /// <summary>
        /// Ejercicio:
        /// 1. Pedir dos números al usuario:
        ///    - El primero será la base.
        ///    - El segundo será la potencia.
        /// 2. Elevar el primer número a la potencia indicada por el segundo número.
        /// 3. Mostrar el resultado en consola.
        /// 4. Usar POO, incluyendo una clase separada para manejar la entrada de datos.
        /// </summary>
        Console.WriteLine("Ingrese la base:");
        int baseNumero = Teclado.LeerInt();

        Console.WriteLine("Ingrese el exponente:");
        int exponente = Teclado.LeerInt();

        double resultado = Calculadora.ElevarPotencia(baseNumero, exponente);

        Console.WriteLine($"El resultado de {baseNumero}^{exponente} es: {resultado}");


        /// <summary>
        /// 1. Programa que permite al usuario registrar clientes en un arreglo y luego mostrarlos.
        /// 2. Pedir al usuario cuántos clientes desea registrar.
        /// 3. Utilizar un bucle while para ingresar los nombres de los clientes.
        /// 4. Guardar los nombres en un arreglo.
        /// 5. Imprimir la lista de clientes registrados.
        /// 6. Usar POO, incluyendo una clase separada para manejar la entrada de datos.
        /// </summary>

        Console.WriteLine("Ingrese el número de clientes a registrar:");
        int cantidadClientes = Teclado.LeerInt();

        string[] clientes = new string[cantidadClientes];
        int i = 0;
        while (i < cantidadClientes)
        {
            Console.WriteLine($"Ingrese el nombre del cliente {i + 1}:");
            clientes[i] = Teclado.LeerTexto();
            i++;
        }

        Console.WriteLine("\nLista de clientes registrados:");
        foreach (string cliente in clientes)
        {
            Console.WriteLine($"- {cliente}");
        }


        /// <summary>
        /// Programa que permite al usuario ingresar una lista de números, 
        /// luego los eleva a una potencia usando Math.Pow y muestra los resultados.
        /// 1. Pedir al usuario cuántos números desea ingresar.
        /// 2. Usar un bucle while para que el usuario ingrese los números y guardarlos en un arreglo.
        /// 3. Pedir un exponente al usuario.
        /// 4. Elevar cada número del arreglo al exponente ingresado, con Math.Pow.
        /// 5. Guardar los resultados en otro arreglo.
        /// 6. Mostrar los números originales y sus resultados.
        /// </summary>
        Console.WriteLine("Ingrese la cantidad de números a registrar:");
        int cantidadNumeros = Teclado.LeerInt();

        double[] numeros = new double[cantidadNumeros];
        double[] resultados = new double[cantidadNumeros];

        int ii = 0;
        while (ii < cantidadNumeros)
        {
            Console.WriteLine($"Ingrese el número {ii + 1}:");
            numeros[ii] = Teclado.LeerDouble();
            ii++;
        }

        Console.WriteLine("Ingrese el exponente:");
        int exponentes = Teclado.LeerInt();

        for (int j = 0; j < cantidadNumeros; j++)
        {
            resultados[j] = Calculadora.ElevarPotencia(numeros[j], exponentes);
        }

        Console.WriteLine("\nResultados:");
        for (int j = 0; j < cantidadNumeros; j++)
        {
            Console.WriteLine($"{numeros[j]} elevado a la {exponentes} = {resultados[j]}");
        }

        /// <summary>
        /// Programa que simula un sistema de login con validación de usuario y contraseña.
        /// Se definen dos arreglos: uno con nombres de usuario y otro con sus respectivas contraseñas.
        /// Se solicita al usuario ingresar su nombre de usuario y contraseña.
        /// Se verifica si el usuario existe y si la contraseña es correcta.
        /// Se muestran mensajes dependiendo del resultado(éxito o fallo en el login).
        /// </summary>
        
        // Arreglos con usuarios y contraseñas predefinidos
        string[] usuarios = { "admin", "usuario1", "invitado" };
        string[] claves = { "1234", "pass1", "guest" };

        Console.WriteLine("=== Sistema de Login ===");

        Console.Write("Ingrese su usuario: ");
        string usuarioIngresado = Teclado.LeerTexto();

        Console.Write("Ingrese su contraseña: ");
        string claveIngresada = Teclado.LeerTexto();

        if (Autenticar(usuarios, claves, usuarioIngresado, claveIngresada))
        {
            Console.WriteLine("\n¡Acceso concedido! Bienvenido, " + usuarioIngresado);
        }
        else
        {
            Console.WriteLine("\nError: Usuario o contraseña incorrectos.");
        }

        /// <summary>
        /// Clase que maneja la autenticación de usuarios.
        /// </summary>
        static bool Autenticar(string[] usuarios, string[] claves, string usuario, string clave)
        {
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == usuario && claves[i] == clave)
                {
                    return true; // Usuario y clave coinciden
                }
            }
            return false; // No se encontró coincidencia
        }
    }
}