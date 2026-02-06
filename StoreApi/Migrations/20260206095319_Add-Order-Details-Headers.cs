using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDetailsHeaders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false),
                    OrderTotalAmount = table.Column<double>(type: "double precision", nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.OrderHeaderId);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "OrderHeaderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Предпосылки демократической в определения сущности создаёт повседневная направлений воздействия.", "https://picsum.photos/640/480/?image=568", "Свободный Меховой Берет", 249.66999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Место различных намеченных кадров кадров современного эксперимент.", "https://picsum.photos/640/480/?image=216", "Свободный Стальной Майка", 246.62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Повседневной финансовых за.", "https://picsum.photos/640/480/?image=579", "Великолепный Бетонный Куртка", 739.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Технологий по оценить.", "https://picsum.photos/640/480/?image=98", "Невероятный Хлопковый Клатч", 213.55000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Важные целесообразности занимаемых работы общественной значимость.", "https://picsum.photos/640/480/?image=773", "Невероятный Стальной Стул", 453.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Начало информационно-пропогандистское финансовых финансовых стороны занимаемых.", "https://picsum.photos/640/480/?image=1035", "Интеллектуальный Стальной Шарф", 430.41000000000003, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Создаёт развития систему влечёт участия начало позиции.", "https://picsum.photos/640/480/?image=1083", "Лоснящийся Бетонный Автомобиль", 904.01999999999998, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Сомнений базы интересный укрепления.", "https://picsum.photos/640/480/?image=749", "Маленький Бетонный Майка", 840.36000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Забывать социально-экономическое предпосылки процесс активом идейные мира.", "https://picsum.photos/640/480/?image=952", "Грубый Хлопковый Стул", 505.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Последовательного показывает опыт массового напрямую форм.", "https://picsum.photos/640/480/?image=739", "Свободный Стальной Носки", 621.45000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Форм кадров определения работы массового модель различных гражданского внедрения.", "https://picsum.photos/640/480/?image=564", "Эргономичный Резиновый Майка", 642.83000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Последовательного порядка потребностям настолько формирования правительством.", "https://picsum.photos/640/480/?image=662", "Великолепный Меховой Сабо", 280.06999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Рост насущным социально-ориентированный особенности информационно-пропогандистское образом.", "https://picsum.photos/640/480/?image=1021", "Большой Меховой Кулон", 35.740000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Участниками показывает активизации требует таким намеченных дальнейших от.", "https://picsum.photos/640/480/?image=846", "Свободный Меховой Компьютер", 463.70999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Уровня структура экономической.", "https://picsum.photos/640/480/?image=1026", "Эргономичный Стальной Портмоне", 413.69999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Дальнейших активом в намеченных эксперимент повседневная специалистов показывает.", "https://picsum.photos/640/480/?image=187", "Невероятный Пластиковый Ножницы", 187.25, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Позиции кадров сущности.", "https://picsum.photos/640/480/?image=580", "Невероятный Неодимовый Стул", 491.68000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Соответствующих качественно поставленных однако с и образом следует задания повышению.", "https://picsum.photos/640/480/?image=154", "Практичный Гранитный Кошелек", 717.57000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Общества базы зависит информационно-пропогандистское работы рост.", "https://picsum.photos/640/480/?image=317", "Потрясающий Деревянный Портмоне", 364.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Участия нами активом.", "Грубый Хлопковый Клатч", 744.49000000000001, "Новинка" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_AppUserId",
                table: "OrderHeaders",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Разнообразный направлений рост массового важную отметить создаёт определения повышение условий.", "https://picsum.photos/640/480/?image=449", "Грубый Натуральный Ботинок", 746.01999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Сомнений постоянное обуславливает существующий.", "https://picsum.photos/640/480/?image=398", "Невероятный Меховой Компьютер", 963.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Порядка демократической нами для позволяет.", "https://picsum.photos/640/480/?image=26", "Грубый Хлопковый Берет", 236.78999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Создание структура организационной прогресса что нас работы порядка поэтапного.", "https://picsum.photos/640/480/?image=370", "Лоснящийся Неодимовый Стул", 934.66999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Прежде позиции дальнейшее прогресса обществом правительством собой порядка.", "https://picsum.photos/640/480/?image=308", "Лоснящийся Хлопковый Шарф", 568.46000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Оценить подготовке таким плановых организации.", "https://picsum.photos/640/480/?image=605", "Лоснящийся Пластиковый Куртка", 653.08000000000004, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Обеспечивает а консультация целесообразности вызывает разнообразный.", "https://picsum.photos/640/480/?image=980", "Свободный Неодимовый Клатч", 824.88, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Социально-экономическое поставленных поставленных повседневной эксперимент социально-экономическое очевидна.", "https://picsum.photos/640/480/?image=787", "Эргономичный Неодимовый Ножницы", 851.5, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Сложившаяся кадров повышение повышение современного реализация прежде экономической управление.", "https://picsum.photos/640/480/?image=666", "Потрясающий Деревянный Компьютер", 639.97000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Влечёт форм прежде разработке.", "https://picsum.photos/640/480/?image=604", "Фантастический Натуральный Сабо", 458.19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "И социально-ориентированный социально-ориентированный вызывает насущным дальнейших зависит.", "https://picsum.photos/640/480/?image=571", "Эргономичный Неодимовый Клатч", 202.91999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Занимаемых общественной рамки постоянное курс управление управление.", "https://picsum.photos/640/480/?image=87", "Свободный Стальной Портмоне", 591.92999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Позволяет интересный формировании играет информационно-пропогандистское постоянный нас нами однако.", "https://picsum.photos/640/480/?image=655", "Великолепный Меховой Берет", 474.05000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Высшего кадровой обучения задача.", "https://picsum.photos/640/480/?image=822", "Грубый Стальной Плащ", 112.59999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Намеченных на направлений представляет.", "https://picsum.photos/640/480/?image=460", "Грубый Кожанный Стул", 46.259999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Анализа качества общественной мира.", "https://picsum.photos/640/480/?image=616", "Свободный Хлопковый Кепка", 116.01000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Место модель инновационный однако формирования технологий информационно-пропогандистское.", "https://picsum.photos/640/480/?image=15", "Эргономичный Резиновый Плащ", 715.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Настолько качественно важную постоянное внедрения позволяет прежде и.", "https://picsum.photos/640/480/?image=692", "Фантастический Стальной Клатч", 146.47, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Важные широким создаёт.", "https://picsum.photos/640/480/?image=135", "Великолепный Натуральный Плащ", 863.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Информационно-пропогандистское значимость порядка богатый сложившаяся формирования поэтапного задач поставленных.", "Маленький Резиновый Берет", 775.25, "Топ за свои деньги" });
        }
    }
}
