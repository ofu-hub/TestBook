# TestBook

Простое веб-приложение для управления списком книг с использованием ASP.NET Core, Razor Pages, Entity Framework Core и SQLite. Приложение поддерживает базовые CRUD-операции (создание, чтение, обновление, удаление), асинхронную обработку данных, поиск по названию книги и сортировку по дате публикации или автору.

## Требования

- .NET 6.0 SDK или выше
- SQLite (встроенная поддержка в Entity Framework Core)

## Установка

1. **Клонируйте репозиторий:**

    ```bash
    git clone https://github.com/ofu-hub/TestBook.git
    cd book-manager
    ```

2. **Установите зависимости:**

    Откройте проект в Visual Studio или выполните следующую команду в терминале:

    ```bash
    dotnet restore
    ```

3. **Примените миграции базы данных:**

    Выполните следующие команды, чтобы создать и применить миграции:

    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

## Запуск

Запустите приложение с помощью Visual Studio или выполните следующую команду:

```bash
dotnet run
