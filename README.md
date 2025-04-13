# 🦷 Sistema de Gestión para Clínica Dental - Windows Forms

Este proyecto es un sistema de escritorio desarrollado en Windows Forms para la gestión eficiente de una clínica dental. El sistema permite manejar usuarios con diferentes roles como **Recepcionista** y **Dentista**, gestionar pacientes, citas, horarios y mantener historiales clínicos.

---

## 🔐 Inicio de Sesión

Al iniciar el sistema, se muestra un formulario de **Login** donde puedes ingresar como **Recepcionista** o **Dentista**.

![image](https://github.com/user-attachments/assets/56c79f5e-97fe-4bcc-ab11-91147656519f)

---

## 👩‍💼 Interfaz para Recepcionista

Una vez que inicias sesión como Recepcionista, se carga el **formulario principal**:

- En la parte inferior izquierda: aparece tu **DNI, nombre completo, rol** y el **tiempo activo en el sistema**.
- En la parte superior izquierda: se muestra el **nombre del sistema**, junto con la **fecha y hora actual**.
- Justo debajo: el **menú principal** con opciones:
  - Paciente
  - Dentistas
  - Salir del sistema

![image](https://github.com/user-attachments/assets/02159911-585d-4ea2-ba66-ed9442b2c3de)
![image](https://github.com/user-attachments/assets/0e147d20-6748-416d-a2f7-b54f08a8846d)


---

### 🦷 Gestión de Dentistas

Al seleccionar la opción **Dentistas**, verás un formulario que muestra la lista de dentistas junto a las siguientes funciones:

- Agregar dentista
- Actualizar dentista
- Eliminar dentista (lógicamente)
- Agregar horario
- Ver horario

![image](https://github.com/user-attachments/assets/5003ba86-c05a-4acc-9c44-dd4087002d4f)

#### ➕ Agregar Dentista

Se abrirá un formulario para completar todos los datos del nuevo dentista.

![image](https://github.com/user-attachments/assets/6df8627c-654d-45ef-8eb9-a45c77b0c38e)

Después de llenar los campos, presiona **Agregar**.
![image](https://github.com/user-attachments/assets/faa275fa-ac88-4c9c-b5fd-21e2605ded3b)


#### 🔍 Buscar Dentista

Para confirmar que se agregó correctamente, puedes buscar al dentista por su **apellido**.
![image](https://github.com/user-attachments/assets/a15ccc18-2920-4b59-976e-295c4c6108b2)

#### 🔄 Actualizar Dentista

Selecciona un dentista y haz clic en **Actualizar**. Modifica los datos y luego presiona **Grabar**.
![image](https://github.com/user-attachments/assets/5fb58763-27a4-4f1c-a844-4f552494c2a6)


#### 🗑️ Eliminar Dentista

Esta acción lo pone en estado **inactivo**, impidiendo que se le agenden citas.
![image](https://github.com/user-attachments/assets/502921ba-75d4-4440-adad-afa48b26eb6c)


---

### 📆 Gestión de Horarios del Dentista

Al presionar **Agregar Horario**, se abre un formulario para seleccionar:

- Día
- Hora de inicio y fin
- Mes y año (predefinidos por defecto)

![image](https://github.com/user-attachments/assets/7eee6c76-4d2e-4bba-adf2-c974a54e164c)
![image](https://github.com/user-attachments/assets/5342d4c0-25d8-4397-8fa5-0b8ea76c5cbc)
![image](https://github.com/user-attachments/assets/b934f8e1-9456-4a1d-a64f-7fb99f5e4905)
![image](https://github.com/user-attachments/assets/c0b6957b-1b02-439e-9bf4-2ac901e0d585)


#### Vista de Horarios

Una vez agregado el horario, se visualizará así:

![image](https://github.com/user-attachments/assets/3e2b4b12-fb0f-4b78-bcf7-9be78f3340b8)

#### Eliminar Horario

- Puedes **eliminar horas específicas**.
![image](https://github.com/user-attachments/assets/0e163bc4-38ab-4ddc-af50-666c441a2b8a)
![image](https://github.com/user-attachments/assets/13fb1180-fe99-464d-9fb2-f0d8395e0be4)
![image](https://github.com/user-attachments/assets/c7f7ae0b-4df8-4d1f-beb5-d5d515b45938)

- También puedes **eliminar todo un día completo** si es feriado o por error.
![image](https://github.com/user-attachments/assets/01aafc27-70bc-457e-922c-bd9d15daed8a)
![image](https://github.com/user-attachments/assets/3caa13ed-ca7b-4e7d-95c4-2304803866cf)
![image](https://github.com/user-attachments/assets/4c0eba76-56cf-458f-972c-7b0e299385b4)

---

## 👥 Gestión de Pacientes y Citas

Al elegir la opción **Pacientes**, se muestra la lista de pacientes y botones para:

- Agregar paciente
- Actualizar paciente
- Agendar cita
- Ver citas
- Cancelar cita
- Ver historial médico

![image](https://github.com/user-attachments/assets/d088026e-baee-4bb4-85cc-ffc31ce91e93)
![image](https://github.com/user-attachments/assets/7b74e6f8-92f4-45a4-b71c-3bb6d3c7da87)


### ➕ Agregar Paciente

Presiona **Agregar** para abrir el formulario e ingresar los datos del paciente.

![image](https://github.com/user-attachments/assets/23be21ed-c6ec-40bd-8059-9ec32f317c79)

Después de llenar los campos, presiona **Agregar** y puedes buscarlo por su apellido.

![image](https://github.com/user-attachments/assets/6c847f9a-5da2-409f-bba1-a55ca4516544)
![image](https://github.com/user-attachments/assets/8a325d4e-a692-48b7-aa4e-21e5f2ab10b5)


### 🔄 Actualizar Paciente

Selecciona un paciente y presiona **Actualizar**, luego guarda los cambios con **Grabar**.
![image](https://github.com/user-attachments/assets/73d574a8-501f-4176-a41b-c06c852dc813)
![image](https://github.com/user-attachments/assets/1b102aa8-fff7-45fb-b847-220352ec3dc8)


---

## 📅 Agendar Cita

Selecciona un paciente y haz clic en **Cita**.

![image](https://github.com/user-attachments/assets/00afee93-6766-49d7-ae24-ab8ef6865875)
![image](https://github.com/user-attachments/assets/a1b58437-d3fd-4bce-a8b4-0b3934cbe975)


1. Elige una **especialidad**.
   ![image](https://github.com/user-attachments/assets/e82de2e0-39de-4f5a-85b1-d74b75c6af28)

3. Se listarán los dentistas disponibles con esa especialidad.
   ![image](https://github.com/user-attachments/assets/faf35b7f-f56a-4e5b-8fb7-e68dc0c9a24a)

5. Presiona **Ver disponibilidad**.
![image](https://github.com/user-attachments/assets/d9ac3582-4a9d-4372-81c9-b505a3dc3c25)




### Reserva de Cita

- Las **horas disponibles aparecen en verde**.
- Puedes navegar por semanas.
- Selecciona fecha y hora, ingresa el **motivo** y presiona **Cita**.

![image](https://github.com/user-attachments/assets/a845a4da-65e5-4cab-9f82-cc2d8b23094a)
![image](https://github.com/user-attachments/assets/192c1f37-2f32-43b5-80bb-ba8c99e0adab)


### Ver Citas

Consulta todas las citas pendientes del paciente.
![image](https://github.com/user-attachments/assets/941d9117-f045-4a44-9316-1fb33a6eca26)
![image](https://github.com/user-attachments/assets/3bff9745-541c-43d6-933a-1abae73957a8)

---

## 🧑‍⚕️ Interfaz para Dentista

Al ingresar como **Dentista**, se muestra:

- En la parte inferior izquierda: **DNI, nombre, rol, especialidad y tiempo en sistema**.
- Se cargan automáticamente las **citas del día**.
- Puedes buscar citas entre 2 fechas.

![image](https://github.com/user-attachments/assets/eaef68c0-87c6-47dd-8564-a57311359651)
![image](https://github.com/user-attachments/assets/f4e70b76-cb7f-4243-81f4-797416f6bc5f)
![image](https://github.com/user-attachments/assets/f6b8cdd4-e5f1-4780-8389-abf094fbc621)


---

### 📝 Historia Clínica

Selecciona una cita y presiona **Historia Clínica** para abrir el formulario donde puedes registrar:

- Tratamiento
- Descripción
- Observaciones

Presiona **Agregar historia clínica**.

![image](https://github.com/user-attachments/assets/c9a44627-98a4-4e66-97ac-030c2391e5c7)
![image](https://github.com/user-attachments/assets/ac23e246-2339-4123-a487-f6939c4fca0f)
![image](https://github.com/user-attachments/assets/cdd31795-0830-4754-82ef-bbbdbe1c2689)
![image](https://github.com/user-attachments/assets/e68b91bb-ad73-4e9c-a948-ec30bdf27252)


#### Ver y Editar Historia Clínica

También puedes ver y modificar una historia clínica existente.

![image](https://github.com/user-attachments/assets/2432b847-995e-465c-953a-3ac3bf4a7e64)
![image](https://github.com/user-attachments/assets/6b42679c-9cb9-4ec4-ad47-7c24bd09bcb0)


---

### 🗓️ Horario del Dentista

Presiona **Ver Horario** para visualizar la disponibilidad semanal.

![image](https://github.com/user-attachments/assets/d6e4528a-9f9f-4cce-8c93-c4ad930524a7)

- Puedes **eliminar horas específicas** o todo un día (por feriados o emergencias).

![image](https://github.com/user-attachments/assets/32b05f86-4ad7-4bbd-bf20-4d0a67241c4f)
![image](https://github.com/user-attachments/assets/1f552e98-0920-4326-ab03-9e1014a33b21)
![image](https://github.com/user-attachments/assets/21cdb17c-d981-4d14-a418-6ffe2ff932b2)
![image](https://github.com/user-attachments/assets/930bb97e-0dcd-4e25-8d02-7343986ec8b5)
![image](https://github.com/user-attachments/assets/e57f7866-891b-47c7-b4f3-0a7a7ba5f783)
![image](https://github.com/user-attachments/assets/e0ca4ef4-c9a8-4925-aaea-d8e62dda2151)

---

## ✅ Funcionalidades Principales

- Gestión de roles (Recepcionista y Dentista)
- Registro y edición de dentistas y pacientes
- Gestión de horarios para dentistas
- Agenda de citas por especialidad
- Registro de historia clínica
- Búsqueda de información por filtros

---

## 💬 Notas Finales

Este sistema fue desarrollado con enfoque en la **usabilidad** y **gestión eficiente** del día a día de una clínica dental.

