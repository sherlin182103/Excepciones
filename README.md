# ⚠️ Excepciones – C# WinForms 💻✨

## 📝 Descripción del Programa

Esta aplicación fue desarrollada en **C# Windows Forms** y permite registrar información estudiantil mediante un formulario interactivo con validaciones automáticas.

El sistema verifica que los datos ingresados sean correctos antes de guardarlos, mostrando mensajes de error cuando algún campo está vacío o contiene información inválida.

El proyecto cuenta con una interfaz moderna, organizada y fácil de usar, utilizando colores personalizados, validaciones con `ErrorProvider` y mensajes de confirmación para mejorar la experiencia del usuario.

📚 Proyecto desarrollado con fines académicos.

---

# 🛠️ Tecnologías Utilizadas

| Tecnología | Descripción |
|---|---|
| 💻 C# | Lenguaje principal del proyecto |
| 🧩 .NET Framework | Framework utilizado |
| 🖼️ Windows Forms | Interfaz gráfica |
| 🛠️ Visual Studio 2022 | Entorno de desarrollo |

---

# ✨ Funcionalidades del Sistema

## 📌 Registro de estudiantes

El formulario permite ingresar:

- 👤 Nombre
- 🔢 Edad
- 📧 Correo electrónico
- 📱 Teléfono

---

## ✅ Validaciones implementadas

El sistema incluye validaciones importantes como:

- Campos obligatorios
- Validación de correo electrónico
- Validación numérica en teléfono
- Restricción de edad (solo menores de 18 años)
- Mensajes de error mediante `ErrorProvider`
- Manejo de excepciones con `try-catch`

---

## ⚙️ Opciones del sistema

| Botón | Función |
|---|---|
| 💾 Guardar | Guarda y valida los datos |
| 🧹 Limpiar | Limpia todos los campos |
| ❌ Salir | Cierra el sistema con confirmación |

---

# 🎨 Características de la Interfaz

- Diseño organizado y moderno
- Formulario maximizado automáticamente
- Uso de colores personalizados
- Panel superior decorativo
- Botones estilizados
- Interfaz amigable y fácil de entender

---

# 💻 Fragmento de Código Importante

## ✅ Validación de Campos

```csharp
private bool ValidarCampos()
{
    bool valido = true;

    errorProvider1.Clear();

    if (string.IsNullOrWhiteSpace(txtNombre.Text))
    {
        errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
        valido = false;
    }

    if (!int.TryParse(txtEdad.Text, out int edad))
    {
        errorProvider1.SetError(txtEdad, "Ingrese un número válido");
        valido = false;
    }
    else if (edad <= 0 || edad >= 18)
    {
        errorProvider1.SetError(txtEdad, "Solo se permiten menores de 18 años");
        valido = false;
    }

    return valido;
}
```

---

# 🖼️ Evidencias del Proyecto

## 📸 Formulario Principal

![Formulario Principal](1.png)

---

## 📸 Validaciones del Sistema

![Validaciones](2.png)

---

## 📸 Diseño de la Interfaz

![Diseño del Sistema](3.png)

---

# 🚀 Ejecución del Proyecto

## 📥 Clonar el repositorio

```bash
git clone https://github.com/TU-USUARIO/TU-REPOSITORIO.git
```

---

## ▶️ Abrir el proyecto

1. Abrir **Visual Studio 2022**
2. Ejecutar el archivo:

```bash
UltimaTarea.sln
```

3. Presionar:

```bash
Ctrl + F5
```

---

# 📂 Estructura del Proyecto

```bash
📁 UltimaTarea
 ┣ 📄 Form1.cs
 ┣ 📄 Form1.Designer.cs
 ┣ 📄 Program.cs
 ┣ 📄 App.config
 ┣ 📄 1.png
 ┣ 📄 2.png
 ┣ 📄 3.png
 ┗ 📄 UltimaTarea.sln
```

---

# 🎓 Contexto Académico

- 📚 Nivel: **Secundaria Técnico Profesional**
- 🧩 Módulo Formativo: **Desarrollo de Aplicaciones**
- 🏫 Curso / Sección: **5D2**
- 📆 Año Escolar: **2025 - 2026**

---

# 👩‍💻 Autora

🌸 **Sherlin Jiménez**

---

# 💗 Nota Final

Proyecto realizado con dedicación, creatividad y esfuerzo académico, fortaleciendo conocimientos en:

- Desarrollo de aplicaciones de escritorio
- Validaciones en formularios
- Manejo de excepciones
- Diseño de interfaces gráficas
- Programación en C# Windows Forms
