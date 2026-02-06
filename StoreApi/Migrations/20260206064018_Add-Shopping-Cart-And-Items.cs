using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingCartAndItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Шагов плановых настолько степени.", "https://picsum.photos/640/480/?image=150", "Потрясающий Пластиковый Стол", 843.71000000000004, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Подготовке повседневной форм оценить настолько дальнейшее новых не базы.", "https://picsum.photos/640/480/?image=175", "Интеллектуальный Пластиковый Портмоне", 991.09000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Направлений сфера кадровой повседневной способствует важную особенности рост намеченных модернизации.", "https://picsum.photos/640/480/?image=866", "Потрясающий Меховой Ботинок", 632.70000000000005, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Эксперимент создаёт сомнений новая гражданского обществом.", "https://picsum.photos/640/480/?image=1020", "Грубый Пластиковый Свитер", 996.25, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Прогрессивного рамки представляет поставленных соответствующей последовательного.", "https://picsum.photos/640/480/?image=288", "Практичный Пластиковый Ножницы", 861.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Правительством национальный укрепления задания повышению таким высшего.", "https://picsum.photos/640/480/?image=648", "Лоснящийся Хлопковый Клатч", 683.67999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Изменений роль для роль повышение целесообразности системы проблем значение задач.", "https://picsum.photos/640/480/?image=1048", "Интеллектуальный Кожанный Свитер", 115.73, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Идейные определения нашей.", "https://picsum.photos/640/480/?image=635", "Маленький Натуральный Куртка", 541.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Повседневная за не существующий принципов а.", "https://picsum.photos/640/480/?image=62", "Потрясающий Кожанный Ботинок", 177.55000000000001, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Обеспечение подготовке обеспечение систему социально-ориентированный структура базы равным.", "https://picsum.photos/640/480/?image=736", "Лоснящийся Натуральный Кошелек", 906.32000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Поэтапного что же поставленных эксперимент богатый с курс.", "https://picsum.photos/640/480/?image=399", "Грубый Резиновый Кошелек", 468.07999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Социально-ориентированный уровня высшего работы изменений сознания позиции сознания.", "https://picsum.photos/640/480/?image=681", "Интеллектуальный Кожанный Клатч", 486.50999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Кругу кругу структуры анализа а условий социально-экономическое потребностям рост.", "https://picsum.photos/640/480/?image=999", "Свободный Пластиковый Куртка", 243.81 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Широким профессионального однако последовательного национальный влечёт систему важную.", "https://picsum.photos/640/480/?image=779", "Большой Неодимовый Носки", 645.00999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "За активности гражданского.", "https://picsum.photos/640/480/?image=1064", "Практичный Кожанный Ботинок", 108.52, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Потребностям другой нашей активизации задания играет гражданского сфера от однако.", "https://picsum.photos/640/480/?image=487", "Лоснящийся Кожанный Носки", 814.99000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Повышению уровня качественно.", "https://picsum.photos/640/480/?image=801", "Невероятный Натуральный Портмоне", 191.84999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Условий формировании систему позиции сложившаяся профессионального концепция от форм предпосылки.", "https://picsum.photos/640/480/?image=171", "Великолепный Стальной Стол", 93.849999999999994, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поэтапного поэтапного начало позиции модернизации создание зависит однако участия материально-технической.", "https://picsum.photos/640/480/?image=534", "Грубый Меховой Майка", 864.98000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Влечёт демократической внедрения соображения соответствующих задания забывать прежде инновационный.", "https://picsum.photos/640/480/?image=631", "Интеллектуальный Неодимовый Шарф", 540.52999999999997, "Топ за свои деньги" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Не принимаемых позиции практика степени модели формирования.", "https://picsum.photos/640/480/?image=287", "Интеллектуальный Неодимовый Компьютер", 221.38999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Однако вызывает сомнений кадров направлений требует социально-ориентированный активом.", "https://picsum.photos/640/480/?image=530", "Великолепный Бетонный Сабо", 607.50999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Позиции последовательного шагов следует реализация специалистов консультация создаёт.", "https://picsum.photos/640/480/?image=486", "Большой Деревянный Ножницы", 672.72000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Целесообразности с соответствующей разнообразный.", "https://picsum.photos/640/480/?image=143", "Потрясающий Кожанный Сабо", 135.63999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Демократической новая последовательного проект принимаемых очевидна опыт.", "https://picsum.photos/640/480/?image=711", "Практичный Натуральный Стол", 18.600000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Нами собой активизации соображения забывать внедрения активизации участия административных.", "https://picsum.photos/640/480/?image=451", "Практичный Хлопковый Ремень", 349.67000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Активности модернизации широкому.", "https://picsum.photos/640/480/?image=626", "Великолепный Кожанный Стул", 43.229999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Зависит особенности массового вызывает качественно рамки сущности зависит роль воздействия.", "https://picsum.photos/640/480/?image=725", "Невероятный Стальной Ремень", 763.89999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Мира важную забывать разнообразный широкому.", "https://picsum.photos/640/480/?image=41", "Свободный Неодимовый Куртка", 802.21000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Формировании кругу шагов гражданского образом позволяет богатый.", "https://picsum.photos/640/480/?image=481", "Лоснящийся Неодимовый Портмоне", 878.80999999999995, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Задания массового процесс.", "https://picsum.photos/640/480/?image=427", "Практичный Неодимовый Кошелек", 88.859999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Проблем интересный поэтапного задача.", "https://picsum.photos/640/480/?image=295", "Великолепный Кожанный Кошелек", 646.84000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Шагов консультация позиции что общественной.", "https://picsum.photos/640/480/?image=352", "Свободный Меховой Куртка", 451.82999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Профессионального прежде насущным новая порядка организации структуры.", "https://picsum.photos/640/480/?image=824", "Грубый Меховой Носки", 189.03999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Порядка принимаемых равным эксперимент уровня разнообразный.", "https://picsum.photos/640/480/?image=1035", "Практичный Неодимовый Стол", 87.560000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Соответствующей модели таким и соответствующей различных создаёт современного.", "https://picsum.photos/640/480/?image=435", "Великолепный Натуральный Портмоне", 48.259999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Уровня соответствующих базы предпосылки анализа задания вызывает участниками высокотехнологичная.", "https://picsum.photos/640/480/?image=741", "Практичный Меховой Стул", 531.55999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Поэтапного задач проблем организации предложений.", "https://picsum.photos/640/480/?image=965", "Интеллектуальный Бетонный Сабо", 758.16999999999996, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Принципов стороны с формировании.", "https://picsum.photos/640/480/?image=342", "Интеллектуальный Бетонный Ремень", 626.38999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Социально-ориентированный формированию формировании.", "https://picsum.photos/640/480/?image=1038", "Лоснящийся Неодимовый Ремень", 551.66999999999996, "Новинка" });
        }
    }
}
