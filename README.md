**EJERCICIO 01**

**Requisitos:**
- Unity 2020.x
- Visual Studio

**Objetivos:**
1. Crear una biblioteca de clases en .Net Framework con Visual Studio.
2. Compilar la biblioteca de clases en formato .dll.
3. Importar la biblioteca de clases en el proyecto de Unity dado.
4. Implementar la biblioteca de clases.
5. Compilar el proyecto de Unity para Windows.

**Procedimientos:**

0. Antes de realizar el ejercicio es necesario realizar un fork de este repositorio y crear una nueva rama con vuestro nombre.
1. La biblioteca de clases debe contener métodos para realizar operaciones básicas de sumar, restar, multiplicar y dividir entre dos factores. Estos métodos recibirán dos parámetros de tipo float que serán los factores de la operación y devolverán un valor de tipo float que será el resultado de la operación. Información relacionada: https://docs.microsoft.com/es-es/dotnet/core/tutorials/library-with-visual-studio
2. La biblioteca de clases debe ser compilada para .Net Framework 4.
3. La biblioteca de clases compilada debe ser importada a el proyecto de Unity dado utilizando la carpeta Plugins. Información relacionada: https://docs.unity3d.com/Manual/UsingDLL.html
4. La biblioteca de clases compilada debe ser implementada conjuntamente con la interfaz dada. El usuario debe ser capaz de introducir los factores a operar, seleccionar la operación a realizar y ejecutar la operación.
5. El proyecto se debe compilar para ser ejecutado en Windows. La compilación del proyecto se debe guardar en una carpeta llamada "build" en la raiz del proyecto de Unity.
