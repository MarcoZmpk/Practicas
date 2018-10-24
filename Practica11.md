# Practica 11

### **Objetivo del cliente:** 
Desarrollar una herramienta que permita sumar y restar dos números. Desplegar el resultado en un campo de texto una vez que se presiona un boton.

---
Requisitos: 
- ¿Qué tipo de múmeros?
> Todos los números reales, enteros, punto decimal
  
- ¿Rango de números? ¿Cuántos dígitos?
> 3 dígitos  
  
- ¿Las operaciones son al mismo tiempo?
> No
  
- ¿Se necesita guardar los resultados anteriores?
> No
  
- ¿Que pasa una vez que se realizó la operación?
> Muestra resultado y mantiene los datos con los que se realizó la operación
  
- ¿Cómo se van a desplegar los errores?
> Que marque dónde está el error, cuál es el error y que no mande resultado
  
- ¿Hay alguna preferencia con las etiquetas?
> Las etiquetas deben de estar ajustadas al máximo número de caracteres permitido
  
- ¿Tamaño de letra?
> 16

Notas:
  - **Agregar un botón de borrar**
  
---
### **Objetivo:**
Desarrollar una herramienta que permita sumar y restar el conjunto de números reales, enteros.
El resultado se debe de desplegar una vez que se presionó el boton de "Resultado" en la aplicación y no debe de ser mayor a 4 dígitos. 
Se debe de realizar la operación de acuerdo a la opción seleccionada.
Ambos campos deben de contener información para poder realizar la operación, en caso contrario la aplicación debe de desplegar un mensaje de error pidiendo al usuario introducir ambos valores.
Los datos introducidos no deben de ser mayores a 3 dígitos.
El tamaño de letra debe de ser de 16px para los campos de entrada y el resultado
Los campos en la forma solo deben de aceptar números

---
### **Análisis de Requisitos**
  R1.  Desarrollar una herramienta que permita sumar y restar el conjunto de números reales, enteros.
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
  
  R2.  El resultado se debe de desplegar una vez que se presionó el boton de "Resultado" en la aplicación y no debe de ser mayor a 4 dígitos.
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
  
  R3. Se debe de realizar la operación de acuerdo a la opción seleccionada
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
    
  R4. Ambos campos deben de contener información para poder realizar la operación
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
    
  R5. La aplicación debe de desplegar un mensaje de error pidiendo al usuario introducir ambos valores cuando un campo no contenga información
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
    
  R6. Los datos de entrada no deben de ser mayores a 3 dígitos.
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
    
  R7. El tamaño de letra debe de ser de 16px para los campos de entrada y el resultado
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
  
  R8. Los campos en la forma solo deben de aceptar números
- [x] Único
- [x] No es contradictorio
- [x] Se puede probar
- [x] No es ambiguo
  
  ---
  ### **Caso de prueba**
  
  Condiciones previas: 
  El dispostivo de prueba debe de ser un dispositovo con sistema operativo Android IceScream Sandwich o mayor.
  La herramienta debe de estar previamente instalada
  
*TestCase ID:* TC1R1
*TestScenario:* Probar que la herramienta permita sumar y restar el conjunto de números reales, enteros
*TestSteps:*
1. Ingresar 100 en el primer campo
2. Ingresar 25 en el segundo campo
3. Seleccionar la operación suma
3. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a 125
*Pass/Fail:*

*TestCase ID:* TC2R1
*TestScenario:* Probar que la herramienta permita sumar y restar el conjunto de números reales, enteros
*TestSteps:*
1. Ingresar 100 en el primer campo
2. Ingresar 25 en el segundo campo
3. Seleccionar la operación resta
3. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a 75
*Pass/Fail:*

*TestCase ID:* TC3R1
*TestScenario:* Probar que la herramienta permita sumar y restar el conjunto de números reales, enteros
*TestSteps:*
1. Ingresar -100 en el primer campo
2. Ingresar -25 en el segundo campo
3. Seleccionar la operación suma
3. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a -125
*Pass/Fail:*

*TestCase ID:* TC4R1
*TestScenario:* Probar que la herramienta permita sumar y restar el conjunto de números reales, enteros
*TestSteps:*
1. Ingresar -100 en el primer campo
2. Ingresar -25 en el segundo campo
3. Seleccionar la operación resta
3. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a -75
*Pass/Fail:*

*TestCase ID:* TC5R1
*TestScenario:* Probar que la herramienta permita sumar y restar el conjunto de números reales, enteros
*TestSteps:*
1. Ingresar 100 en el primer campo
2. Ingresar -25 en el segundo campo
3. Seleccionar la operación suma
3. Presionar el boton de Resultado
*Expected Results:*
La aplicación debe de desplegar el resultado igual a -75
*Pass/Fail:*
  
  2.  El resultado se debe de desplegar una vez que se presionó el boton de "Resultado" en la aplicación y no debe de ser mayor a 4 dígitos.

  
  3. Se debe de realizar la operación de acuerdo a la opción seleccionada

    
  4. Ambos campos deben de contener información para poder realizar la operación

    
  5. La aplicación debe de desplegar un mensaje de error pidiendo al usuario introducir ambos valores cuando un campo no contenga información

    
  6. Los datos de entrada no deben de ser mayores a 3 dígitos.

    
  7. El tamaño de letra debe de ser de 16px para los campos de entrada y el resultado

  
  8. Los campos en la forma solo deben de aceptar números
  
  
