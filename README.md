# 🎮 FunkoPopApi

Proyecto sencillo realizado en **C# con ASP.NET Core** para tener una primera toma de contacto con la creación de una **API REST**.

La aplicación permite gestionar una colección de Funkos almacenados en memoria mediante un repositorio.

## 🚀 Funcionalidades

La API permite realizar las operaciones básicas de un CRUD:

- Obtener todos los Funkos.
- Obtener un Funko por su ID.
- Crear nuevos Funkos.
- Actualizar un Funko existente.
- Eliminar un Funko.

Los datos se almacenan temporalmente en un `Dictionary`, por lo que se pierden al detener la aplicación.

También se incluyen algunos Funkos por defecto al iniciar la API para poder realizar pruebas fácilmente.

## 🛠 Tecnologías utilizadas

- C#
- ASP.NET Core
- Minimal APIs
- Inyección de dependencias
- Repositorio en memoria
- Bruno para probar los endpoints de la API

## 🧪 Pruebas con Bruno

Para comprobar el funcionamiento de la API se utiliza **Bruno**, desde donde se realizan peticiones HTTP a los diferentes endpoints utilizando los métodos:

`GET`, `POST`, `PUT` y `DELETE`.

## 📚 Objetivo

El objetivo principal de este proyecto es aprender los conceptos básicos de una API REST, comprender cómo funcionan las rutas y los métodos HTTP y practicar la separación del código mediante modelos, repositorios y rutas.

Es mi primera toma de contacto desarrollando una API, por lo que el proyecto está planteado de forma sencilla antes de empezar a trabajar con bases de datos, servicios, DTOs u otras estructuras más avanzadas.
