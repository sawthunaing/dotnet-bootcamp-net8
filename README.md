# GameStore API

A RESTful Web API for managing a video game catalog, built with ASP.NET Core and .NET 8. This is my daily learning project as I work through a .NET bootcamp.

## About

I'm building this project one lesson at a time to learn backend development with C# and ASP.NET Core. The repository is updated daily so I can track my own progress and practise building a real API from scratch.

## Tech Stack

- **.NET 8** — target framework
- **ASP.NET Core Minimal APIs** — HTTP endpoints
- **C#** — with nullable reference types and implicit usings enabled

## Features

The API currently supports full CRUD operations for games and genres:

- `GET /games` — list all games
- `GET /games/{id}` — get a single game by ID
- `POST /games` — create a new game
- `PUT /games/{id}` — update an existing game
- `DELETE /games/{id}` — delete a game
- `GET /genres` — list all genres

Data is stored in memory for now.

## Project Structure