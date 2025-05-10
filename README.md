# BusquedaPalabra

Una API REST construida en ASP.NET Core Web API que permite verificar si una palabra está contenida dentro de una matriz de caracteres (como una sopa de letras), en **cuatro direcciones posibles**:  
➡️ Horizontal, ⬇️ Vertical, ↘️ Diagonal principal y ↗️ Diagonal inversa.

---

## 📌 Ejemplo

```json
{
  "info": ["ATFVRA", "B4KHES", "5JENTY", "T6IRF3", "ELLJ54", "24JKRT"],
  "nombre": "LINEA"
}
```

---

## ✅ Resultado esperado:

```json
{
  "resultado": true
}
```

---

## ⚙️ Tecnologías utilizadas

- ASP.NET Core Web API (.NET 7 o superior)
- C#
- Swagger para documentación automática

---

## 🚀 Instalación y ejecución local

- 🔧 Requisitos previos
- .NET SDK 7.0 o Superior
- Visual Studio 2022 o VS Code con extensión C#

---

## 📥 Clonar el repositorio

```bash
git clone https://github.com/tuusuario/BusquedaPalabraAPI.git
cd BusquedaPalabraAPI
```

---

## 🛠 Abrir en Visual Studio

### 1. Abre BusquedaPalabraAPI.sln en Visual Studio.
### 2. Presiona F5 para iniciar la API.

---

## Probar con Swagger

Una vez ejecutado el proyecto, se abrirá automáticamente Swagger UI:
https://localhost:<puerto>/swagger/index.html
