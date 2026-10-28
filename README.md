# Ibragimov Variant 9

Учебный ASP.NET Core Web API, выполненный по лабораторным работам №1–3 для варианта 9 «Учёт студентов и их успеваемость».

## Выполненные лабораторные

- лабораторная №1: проект ASP.NET Core Web API и работа с Git;
- лабораторная №2: NLog, тестовое логирование, GET и POST в `WeatherForecastController`, Swagger;
- лабораторная №3: PostgreSQL, Entity Framework Core, контекст БД, модели, Fluent API и миграции.

CRUD-сервисы, фильтры и другие задания последующих лабораторных в проект не входят.

## Запуск

1. Установить и запустить PostgreSQL.
2. В `Ibragimov_Variant9/appsettings.Development.json` указать пароль пользователя `postgres` в строке `DefaultConnection`.
3. В консоли диспетчера пакетов Visual Studio выполнить `Update-Database`.
4. Запустить проект с профилем `http` и открыть `http://localhost:5056/swagger`.

База данных проекта называется `ibragimov_variant9_db`.

## Схема базы данных

- `Specialtys`: `SpecialtyId`, `Title`, `Code`;
- `Groups`: `GroupId`, `Name`, `Course`, `SpecialtyId`, `IsDeleted`;
- `Students`: `StudentId`, `FirstName`, `LastName`, `GroupId`, `IsDeleted`;
- `Disciplines`: `DisciplineId`, `Name`, `IsDeleted`;
- `Grades`: `GradeId`, `Value`, `StudentId`, `DisciplineId`.
