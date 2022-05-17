# Nombre del Repositorio: Laboratorio_II_Parcial_1

# Nombre de la Solución: Brito.Eduard.2D.Parcial_1

# Nombre de los proyectos: Formularios y Biblioteca

## INTRODUCCION

El famoso bar LES UTN nos ha encomendado la tarea de diseñar un sistema en .NET utilizando
Windows Forms que le ayude a administrar su negocio.
El bar posee las siguientes características básicas:

* El bar posee 15 mesas numeradas del 1 al 15, y una barra con capacidad para 5 personas
enumeradas del 16 en adelante. Por protocolo covid, las personas que vayan a la barra solo
podrán consumir bebidas y no podrán ordenar platos, para no congestionar esa zona.
* El bar posee estacionamiento que se abonará como costo adicional al pedir la cuenta.
* Se aceptan todos los métodos de pago, pero al utilizar tarjeta de crédito se agrega un 10%
de recargo al monto final.
* Al bar lo atienden tanto empleados como sus dueños.

## REQUERIMIENTOS DEL SISTEMA

1. Administrar usuarios: debe poder diferenciar un empleado de un administrador.

  * a. Empleado.
    i. El empleado deberá poder gestionar cada mesa y cobrar.
    ii. Deberá poder hacer una venta (cargar un pedido) a un cliente determinado siempre y cuando se den 
    las condiciones de venta,por ej, que haya stock de ese producto que solicitó el cliente.

  * b. Administrador.
    i. Deberá poder realizar las mismas tareas que el empleado.
    ii. Podrá acceder a ver la información de todos los empleados registrados en la aplicación.
    iii. Agregar nuevos productos al inventario y rellenar el stock de mercadería nuevamente.
    
2. Administrar el inventario:

  * a. El sistema deberá poder informar a quien esté logueado como viene de provisiones
     el local. Debe tener alguna sección donde se pueda ver el estado del stock y se
     pueda notar de forma ágil que algún producto está por acabarse.
     
3. Administrar ventas:

  * a. El sistema deberá poder manejar por cliente cuánto llevan consumido hasta el
     momento.
  * b. El sistema deberá ser capaz de cerrar la mesa y cobrar.
  
  ## Conceptos de objetos utilizados para desarrollar la aplicación:
  
  * Herencia
  * Sobrecarga de constructores y métodos
  * Propiedades
  * Colecciones
  * Enumerados
  * Formularios modal.
  * Clases estáticas 
  * Polimorfismo (clases abstractas, métodos abstractos, métodos virtuales)
  
  ## DIAGRAMA DE CLASES:
  
  ![image](https://user-images.githubusercontent.com/60559234/168914156-31611177-c581-4ff2-a023-87fa8bca239b.png)

  ![image](https://user-images.githubusercontent.com/60559234/168913937-deba6e33-0cfc-4a70-8358-b770b7399ef6.png)

  
