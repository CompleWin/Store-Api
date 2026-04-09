# Store API

REST API интернет-магазина, реализованный на **ASP.NET Core (.NET 10)** с использованием **Entity Framework Core** и **PostgreSQL**. 
Поддерживает аутентификацию через JWT, управление товарами, корзиной, заказами и оплатой. Изображения товаров хранятся в S3 хранилище.

## Стек технологий

- **Платформа:** ASP.NET Core (.NET 10)
- **ORM:** Entity Framework Core 10 + Npgsql (PostgreSQL)
- **Аутентификация:** ASP.NET Core Identity + JWT Bearer
- **Хранилище файлов:** AWS SDK S3 (TimeWeb S3)
- **Документация:** Swagger / OpenAPI 
- **Прочее:** Bogus (генерация тестовых данных)

## Быстрый старт

### Требования

- .NET 10 SDK
- PostgreSQL
- S3-совместимое хранилище (или заглушка)

### Запуск

```bash
git clone https://github.com/CompleWin/Store-Api.git
cd Store-Api/StoreApi

# Настройте строку подключения и S3 в appsettings.json

dotnet ef database update
dotnet run
```

Swagger UI доступен по адресу: `http://localhost:<port>/swagger`

## Роли пользователей

| Роль       | Описание                          |
|------------|-----------------------------------|
| `Admin`    | Полный доступ ко всем ресурсам    |
| `Consumer` | Доступ к корзине, заказам, оплате |

---

## Эндпоинты API

### 🔐 Auth — Аутентификация

Базовый путь: `/api/Auth`

| Метод | Путь                    | Доступ | Описание               |
|-------|-------------------------|--------|------------------------|
| POST  | `/api/Auth/Register`    | Все    | Регистрация нового пользователя |
| POST  | `/api/Auth/Login`       | Все    | Вход и получение JWT-токена     |

#### POST `/api/Auth/Register`

**Body (JSON):**
```json
{
  "userName": "string",
  "email": "string",
  "password": "string",
  "role": "Admin | Consumer"
}
```

#### POST `/api/Auth/Login`

**Body (JSON):**
```json
{
  "email": "string",
  "password": "string"
}
```

**Ответ:**
```json
{
  "isSucces": true,
  "statusCode": 200,
  "response": {
    "email": "string",
    "token": "<JWT>"
  }
}
```

---

### 📦 Product — Товары

Базовый путь: `/api/Product`

| Метод  | Путь                                           | Доступ | Описание                          |
|--------|------------------------------------------------|--------|-----------------------------------|
| GET    | `/api/Product/GetProducts`                     | Все    | Получить все товары               |
| GET    | `/api/Product/FetchProductsWithPagination`     | Все    | Товары с пагинацией               |
| GET    | `/api/Product/GetProductById/{id}`             | Все    | Получить товар по ID              |
| POST   | `/api/Product/CreateProduct`                   | Все    | Создать новый товар               |
| PUT    | `/api/Product/UpdateProduct?id={id}`           | Все    | Обновить товар                    |
| DELETE | `/api/Product/DeleteProduct?id={id}`           | Все    | Удалить товар                     |

#### GET `/api/Product/FetchProductsWithPagination`

**Query-параметры:**

| Параметр | Тип | По умолчанию | Описание              |
|----------|-----|--------------|-----------------------|
| `skip`   | int | 0            | Сколько записей пропустить |
| `take`   | int | 5            | Сколько записей вернуть    |

#### POST `/api/Product/CreateProduct`

**Body (multipart/form-data):**

| Поле          | Тип    | Обязательное | Описание          |
|---------------|--------|--------------|-------------------|
| `name`        | string | ✅           | Название товара   |
| `description` | string | ✅           | Описание          |
| `category`    | string | —            | Категория         |
| `price`       | double | ✅           | Цена (1–1000)     |
| `specialTag`  | string | —            | Специальный тег   |
| `image`       | file   | ✅           | Изображение       |

#### PUT `/api/Product/UpdateProduct`

Аналогично `CreateProduct`, но в query-параметрах передаётся `id`, а `image` необязательно — если не передано, старое изображение сохраняется.

---

### 🛒 ShoppingCart — Корзина

Базовый путь: `/api/ShoppingCart`

| Метод | Путь                                          | Доступ | Описание                          |
|-------|-----------------------------------------------|--------|-----------------------------------|
| GET   | `/api/ShoppingCart/AppendOrUpdateItemInCart`  | Все    | Добавить/обновить товар в корзине |
| GET   | `/api/ShoppingCart/GetShoppingCart`           | Все    | Получить корзину пользователя     |

#### GET `/api/ShoppingCart/AppendOrUpdateItemInCart`

**Query-параметры:**

| Параметр         | Тип    | Описание                                                |
|------------------|--------|---------------------------------------------------------|
| `userId`         | string | ID пользователя                                         |
| `productId`      | int    | ID товара                                               |
| `updateQuantity` | int    | Новое количество (0 — удалить товар из корзины)         |

#### GET `/api/ShoppingCart/GetShoppingCart`

**Query-параметры:**

| Параметр | Тип    | Описание        |
|----------|--------|-----------------|
| `userId` | string | ID пользователя |

---

### 📋 Order — Заказы

Базовый путь: `/api/Order`

| Метод | Путь                                  | Доступ | Описание                      |
|-------|---------------------------------------|--------|-------------------------------|
| POST  | `/api/Order/CreateOrder`              | Все    | Создать новый заказ           |
| GET   | `/api/Order/GetOrderById/{id}`        | Все    | Получить заказ по ID          |
| GET   | `/api/Order/GetOrdersByUserId/{userId}` | Все  | Получить заказы пользователя  |
| PUT   | `/api/Order/UpdateOrderHeader/{orderId}` | Все | Обновить заголовок заказа     |

#### POST `/api/Order/CreateOrder`

**Body (JSON):**
```json
{
  "customerName": "string",
  "customerEmail": "string",
  "appUserId": "string",
  "orderTotalAmount": 0.0,
  "status": "string",
  "totalCount": 0,
  "orderDetailsDto": [
    {
      "productId": 0,
      "quantity": 0,
      "itemName": "string",
      "price": 0.0
    }
  ]
}
```

#### PUT `/api/Order/UpdateOrderHeader/{orderId}`

**Body (JSON):**
```json
{
  "status": "string",
  "sessionId": "string",
  "paymentIntentId": "string"
}
```

---

### 💳 Payment — Оплата

| Метод | Путь               | Доступ | Описание         |
|-------|--------------------|--------|------------------|
| POST  | `/MakePayment`     | Все    | Выполнить оплату |

#### POST `/MakePayment`

**Query-параметры:**

| Параметр     | Тип    | Описание        |
|--------------|--------|-----------------|
| `userId`     | string | ID пользователя |
| `orderId`    | int    | ID заказа       |
| `cardNumber` | string | Номер карты     |

> ⚠️ Используется `FakePaymentService` — реальная платёжная логика не реализована.

---

### 🧪 AuthTest — Тесты авторизации

Базовый путь: `/api/AuthTest`

| Метод | Путь                    | Доступ              | Описание                        |
|-------|-------------------------|---------------------|---------------------------------|
| GET   | `/api/AuthTest/Test1`   | Все                 | Доступен всем                   |
| GET   | `/api/AuthTest/Test2`   | Авторизованные      | Требует валидный JWT            |
| GET   | `/api/AuthTest/Test3`   | Роль `Consumer`     | Только для Consumer             |
| GET   | `/api/AuthTest/Test4`   | Роль `Admin`        | Только для Admin                |

---

## Формат ответа

Все эндпоинты возвращают единый объект `ResponseServer`:

```json
{
  "isSucces": true,
  "statusCode": 200,
  "errorMessages": [],
  "response": { }
}
```

## Структура проекта

```
StoreApi/
├── Controllers/       # Контроллеры API
├── Model/             # Модели данных (Product, AppUser, Order, …)
├── ModelDto/          # DTO для запросов
├── Service/           # Бизнес-логика (Cart, Order, JWT, Payment, Storage)
├── Extensions/        # Регистрация сервисов
├── Data/              # AppDbContext
├── Migrations/        # Миграции EF Core
└── Seed/              # Генерация тестовых данных (Bogus)
```
