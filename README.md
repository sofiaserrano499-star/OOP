# OOP
Se requiere considerar a todos los atributos como protected a menos que se indique lo contrario y 
los getters y setters correspondientes a cada atributo.
Se desea además que para cada ejercicio se logre realizar una colección (lista) de objetos creados 
por su clase padre y a su vez, mostrar todos los elementos disponibles en la lista. 
Defina dentro del main métodos para: 
Agregar un nuevo elemento (de cualquier tipo).
Modificar los datos de un elemento existente.
Eliminar un elemento por su Id.
Ejercicio 1 – Gestión de vehículos
Diseñe un sistema para administrar los vehículos que ingresan a un taller.
Cree una clase padre Vehiculo con los atributos: Id, Marca, Modelo y Año.
A partir de ella, crear las clases Auto, Moto y Camion, que agreguen atributos específicos (por 
ejemplo, cantidadPuertas, cilindrada, capacidadCarga).
Ejercicio 2 – Sistema de empleados
Implemente una aplicación para gestionar empleados de una empresa.
Cree una clase Empleado con Id, Nombre, Apellido y SueldoBase.
Genere las clases hijas EmpleadoPermanente y EmpleadoTemporal, que redefinan el método 
CalcularSueldo() según su modalidad. Un ejemplo podría ser que el empleado permanente tiene un 
extra de antigüedad. 
Ejercicio 3 – Inventario de productos
Se desea desarrollar un sistema para gestionar el inventario de una tienda.
Cree una clase padre Producto con los atributos Id, Nombre y PrecioBase.
A partir de ella, crear las clases hijas ProductoAlimenticio (con FechaVencimiento) y 
ProductoElectronico (con MesesGarantia).
Extra:
Listar todo el inventario mostrando el tipo de producto.
Ejercicio 4 – Gestión educativa
Desarrolle un sistema para registrar las personas de una institución educativa.
Cree la clase padre Persona con Id, Nombre, Edad.
Crear las clases hijas Alumno (con Legajo y Promedio) y Profesor (con Materia y Sueldo).
Extra:
Listado general, diferenciando alumnos y profesores.
Ejercicio 5 – Sistema bancario
Cree una aplicación para administrar cuentas bancarias.
Defina la clase Cuenta con NumeroCuenta, Titular y Saldo.
Clases hijas: CajaAhorro (con tasa de interés) y CuentaCorriente (con límite de descubierto).
La aplicación deberá permitir:
Registrar Cuentas.
Realizar depósitos y extracciones.
Aplicar intereses o actualizar saldos.
Listar todas las cuentas mostrando su tipo y saldo.
Los datos se almacenarán en una List<Cuenta>
