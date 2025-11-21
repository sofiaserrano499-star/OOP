using System;
using System.Collections.Generic;

namespace Ejercicios
{
//Ejercicio 1
    public class Vehiculo
    {
        protected int id;
        protected string marca;
        protected string modelo;
        protected int año;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Año { get => año; set => año = value; }

        public Vehiculo(int id, string marca, string modelo, int año)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"[Vehículo] Id:{id} Marca:{marca} Modelo:{modelo} Año:{año}");
        }
    }

    public class Auto : Vehiculo
    {
        protected int cantidadPuertas;

        public int CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }

        public Auto(int id, string marca, string modelo, int año, int cantidadPuertas)
            : base(id, marca, modelo, año)
        {
            this.cantidadPuertas = cantidadPuertas;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[AUTO] Id:{id} Marca:{marca} Modelo:{modelo} Año:{año} Puertas:{cantidadPuertas}");
        }
    }

    public class Moto : Vehiculo
    {
        protected int cilindrada;

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }

        public Moto(int id, string marca, string modelo, int año, int cilindrada)
            : base(id, marca, modelo, año)
        {
            this.cilindrada = cilindrada;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[MOTO] Id:{id} Marca:{marca} Modelo:{modelo} Año:{año} Cilindrada:{cilindrada}cc");
        }
    }

    public class Camion : Vehiculo
    {
        protected double capacidadCarga;

        public double CapacidadCarga { get => capacidadCarga; set => capacidadCarga = value; }

        public Camion(int id, string marca, string modelo, int año, double capacidadCarga)
            : base(id, marca, modelo, año)
        {
            this.capacidadCarga = capacidadCarga;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[CAMIÓN] Id:{id} Marca:{marca} Modelo:{modelo} Año:{año} Carga:{capacidadCarga} tn");
        }
    }


//Ejercicio 2
    public class Empleado
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected decimal sueldoBase;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal SueldoBase { get => sueldoBase; set => sueldoBase = value; }

        public Empleado(int id, string nombre, string apellido, decimal sueldoBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBase = sueldoBase;
        }

        public virtual decimal CalcularSueldo()
        {
            return sueldoBase;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"[Empleado] {id} - {nombre} {apellido} SueldoBase:{sueldoBase}");
        }
    }

    public class EmpleadoPermanente : Empleado
    {
        protected int añosAntiguedad;

        public int AñosAntiguedad { get => añosAntiguedad; set => añosAntiguedad = value; }

        public EmpleadoPermanente(int id, string nombre, string apellido, decimal sueldoBase, int añosAntiguedad)
            : base(id, nombre, apellido, sueldoBase)
        {
            this.añosAntiguedad = añosAntiguedad;
        }

        public override decimal CalcularSueldo()
        {
            decimal extra = sueldoBase * 0.02m * añosAntiguedad;
            return sueldoBase + extra;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Perm.] {id} - {nombre} {apellido} Base:{sueldoBase} Antig:{añosAntiguedad} SueldoFinal:{CalcularSueldo()}");
        }
    }

    public class EmpleadoTemporal : Empleado
    {
        protected int mesesContrato;

        public int MesesContrato { get => mesesContrato; set => mesesContrato = value; }

        public EmpleadoTemporal(int id, string nombre, string apellido, decimal sueldoBase, int mesesContrato)
            : base(id, nombre, apellido, sueldoBase)
        {
            this.mesesContrato = mesesContrato;
        }

        public override decimal CalcularSueldo()
        {
            return sueldoBase + 2000m;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Temp.] {id} - {nombre} {apellido} Base:{sueldoBase} Meses:{mesesContrato} SueldoFinal:{CalcularSueldo()}");
        }
    }

    

//Ejercicio 3

    public class Producto
    {
        protected int id;
        protected string nombre;
        protected decimal precioBase;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal PrecioBase { get => precioBase; set => precioBase = value; }

        public Producto(int id, string nombre, decimal precioBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioBase = precioBase;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"[Producto] Id:{id} Nombre:{nombre} Precio:{precioBase}");
        }
    }

    public class ProductoAlimenticio : Producto
    {
        protected DateTime fechaVencimiento;

        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }

        public ProductoAlimenticio(int id, string nombre, decimal precioBase, DateTime fechaVencimiento)
            : base(id, nombre, precioBase)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Alimento] Id:{id} Nombre:{nombre} Precio:{precioBase} Vence:{fechaVencimiento:dd/MM/yyyy}");
        }
    }

    public class ProductoElectronico : Producto
    {
        protected int mesesGarantia;

        public int MesesGarantia { get => mesesGarantia; set => mesesGarantia = value; }

        public ProductoElectronico(int id, string nombre, decimal precioBase, int mesesGarantia)
            : base(id, nombre, precioBase)
        {
            this.mesesGarantia = mesesGarantia;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Electrónico] Id:{id} Nombre:{nombre} Precio:{precioBase} Garantía:{mesesGarantia} meses");
        }
    }


//Ejercicio 4
    public class Persona
    {
        protected int id;
        protected string nombre;
        protected int edad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(int id, string nombre, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"[Persona] Id:{id} Nombre:{nombre} Edad:{edad}");
        }
    }

    public class Alumno : Persona
    {
        protected string legajo;
        protected double promedio;

        public string Legajo { get => legajo; set => legajo = value; }
        public double Promedio { get => promedio; set => promedio = value; }

        public Alumno(int id, string nombre, int edad, string legajo, double promedio)
            : base(id, nombre, edad)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Alumno] Id:{id} Nombre:{nombre} Edad:{edad} Legajo:{legajo} Promedio:{promedio}");
        }
    }

    public class Profesor : Persona
    {
        protected string materia;
        protected decimal sueldo;

        public string Materia { get => materia; set => materia = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }

        public Profesor(int id, string nombre, int edad, string materia, decimal sueldo)
            : base(id, nombre, edad)
        {
            this.materia = materia;
            this.sueldo = sueldo;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[Profesor] Id:{id} Nombre:{nombre} Edad:{edad} Materia:{materia} Sueldo:{sueldo}");
        }
    }


//Ejercicio 5

    public class Cuenta
    {
        protected int numeroCuenta;
        protected string titular;
        protected decimal saldo;

        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public string Titular { get => titular; set => titular = value; }
        public decimal Saldo { get => saldo; protected set => saldo = value; }

        public Cuenta(int numeroCuenta, string titular, decimal saldoInicial)
        {
            this.numeroCuenta = numeroCuenta;
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        public virtual void Depositar(decimal monto)
        {
            if (monto > 0) saldo += monto;
        }

        public virtual bool Extraer(decimal monto)
        {
            if (monto <= 0) return false;
            if (monto <= saldo)
            {
                saldo -= monto;
                return true;
            }
            return false;
        }

        public virtual void ActualizarSaldo()
    {
      
    }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"[Cuenta] Nro:{numeroCuenta} Titular:{titular} Saldo:{saldo}");
        }
    }

    public class CajaAhorro : Cuenta
    {
        protected decimal tasaInteres; 

        public decimal TasaInteres { get => tasaInteres; set => tasaInteres = value; }

        public CajaAhorro(int numeroCuenta, string titular, decimal saldoInicial, decimal tasaInteres)
            : base(numeroCuenta, titular, saldoInicial)
        {
            this.tasaInteres = tasaInteres;
        }

        public override void ActualizarSaldo()
        {
            saldo += saldo * tasaInteres;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[CajaAhorro] Nro:{numeroCuenta} Titular:{titular} Saldo:{saldo} Tasa:{tasaInteres * 100}%");
        }
    }

    public class CuentaCorriente : Cuenta
    {
        protected decimal limiteDescubierto;

        public decimal LimiteDescubierto { get => limiteDescubierto; set => limiteDescubierto = value; }

        public CuentaCorriente(int numeroCuenta, string titular, decimal saldoInicial, decimal limiteDescubierto)
            : base(numeroCuenta, titular, saldoInicial)
        {
            this.limiteDescubierto = limiteDescubierto;
        }

        public override bool Extraer(decimal monto)
        {
            if (monto <= 0) return false;

            if (saldo - monto >= -limiteDescubierto)
            {
                saldo -= monto;
                return true;
            }
            return false;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[CtaCte] Nro:{numeroCuenta} Titular:{titular} Saldo:{saldo} Descubierto:{limiteDescubierto}");
        }
    }



    class Program
    {
        static List<Vehiculo> vehiculos = new List<Vehiculo>();
        static List<Empleado> empleados = new List<Empleado>();
        static List<Producto> productos = new List<Producto>();
        static List<Persona> personas = new List<Persona>();
        static List<Cuenta> cuentas = new List<Cuenta>();

        static void Main(string[] args)
        {
     

            AgregarVehiculo(new Auto(1, "Ford", "Fiesta", 2015, 4));
            AgregarVehiculo(new Moto(2, "Yamaha", "FZ", 2020, 150));
            AgregarVehiculo(new Camion(3, "Mercedes", "Actros", 2018, 20));

            Console.WriteLine("=== Vehículos iniciales ===");
            ListarVehiculos();

            ModificarVehiculo(1, "Ford", "Focus", 2017); 
            EliminarVehiculo(2);                       

            Console.WriteLine("\n=== Vehículos después de modificar/eliminar ===");
            ListarVehiculos();

            RegistrarCuenta(new CajaAhorro(100, "Sofía", 50000m, 0.05m));
            RegistrarCuenta(new CuentaCorriente(101, "Juan", 20000m, 10000m));

            Console.WriteLine("\n=== Cuentas iniciales ===");
            ListarCuentas();

            DepositarEnCuenta(100, 5000m);
            ExtraerDeCuenta(101, 25000m);  
            AplicarInteresesActualizacion();

            Console.WriteLine("\n=== Cuentas después de operaciones ===");
            ListarCuentas();

            Console.ReadKey();
        }


        static void AgregarVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
        }

        static void ModificarVehiculo(int id, string nuevaMarca, string nuevoModelo, int nuevoAño)
        {
            Vehiculo v = vehiculos.Find(x => x.Id == id);
            if (v != null)
            {
                v.Marca = nuevaMarca;
                v.Modelo = nuevoModelo;
                v.Año = nuevoAño;
            }
        }

        static void EliminarVehiculo(int id)
        {
            Vehiculo v = vehiculos.Find(x => x.Id == id);
            if (v != null)
            {
                vehiculos.Remove(v);
            }
        }

        static void ListarVehiculos()
        {
            foreach (var v in vehiculos)
            {
                v.MostrarDatos();
            }
        }



        static void AgregarEmpleado(Empleado e)
        {
            empleados.Add(e);
        }

        static void ModificarEmpleado(int id, string nuevoNombre, string nuevoApellido, decimal nuevoSueldoBase)
        {
            Empleado emp = empleados.Find(x => x.Id == id);
            if (emp != null)
            {
                emp.Nombre = nuevoNombre;
                emp.Apellido = nuevoApellido;
                emp.SueldoBase = nuevoSueldoBase;
            }
        }

        static void EliminarEmpleado(int id)
        {
            Empleado emp = empleados.Find(x => x.Id == id);
            if (emp != null)
            {
                empleados.Remove(emp);
            }
        }

        static void ListarEmpleados()
        {
            foreach (var emp in empleados)
            {
                emp.MostrarDatos();
            }
        }


        static void AgregarProducto(Producto p)
        {
            productos.Add(p);
        }

        static void ModificarProducto(int id, string nuevoNombre, decimal nuevoPrecio)
        {
            Producto p = productos.Find(x => x.Id == id);
            if (p != null)
            {
                p.Nombre = nuevoNombre;
                p.PrecioBase = nuevoPrecio;
            }
        }

        static void EliminarProducto(int id)
        {
            Producto p = productos.Find(x => x.Id == id);
            if (p != null)
            {
                productos.Remove(p);
            }
        }

        static void ListarProductos()
        {
            foreach (var p in productos)
            {
                p.MostrarDatos(); 
            }
        }


        static void AgregarPersona(Persona p)
        {
            personas.Add(p);
        }

        static void ModificarPersona(int id, string nuevoNombre, int nuevaEdad)
        {
            Persona per = personas.Find(x => x.Id == id);
            if (per != null)
            {
                per.Nombre = nuevoNombre;
                per.Edad = nuevaEdad;
            }
        }

        static void EliminarPersona(int id)
        {
            Persona per = personas.Find(x => x.Id == id);
            if (per != null)
            {
                personas.Remove(per);
            }
        }

        static void ListarPersonas()
        {
            foreach (var p in personas)
            {
                p.MostrarDatos();
            }
        }


        static void RegistrarCuenta(Cuenta c)
        {
            cuentas.Add(c);
        }

        static void DepositarEnCuenta(int numeroCuenta, decimal monto)
        {
            Cuenta c = cuentas.Find(x => x.NumeroCuenta == numeroCuenta);
            if (c != null)
            {
                c.Depositar(monto);
            }
        }

        static void ExtraerDeCuenta(int numeroCuenta, decimal monto)
        {
            Cuenta c = cuentas.Find(x => x.NumeroCuenta == numeroCuenta);
            if (c != null)
            {
                bool ok = c.Extraer(monto);
                if (!ok)
                {
                    Console.WriteLine($"No se pudo extraer {monto} de la cuenta {numeroCuenta}");
                }
            }
        }

        static void AplicarInteresesActualizacion()
        {
            foreach (var c in cuentas)
            {
                c.ActualizarSaldo();
            }
        }

        static void ListarCuentas()
        {
            foreach (var c in cuentas)
            {
                c.MostrarDatos();
            }
        }

    }
}
