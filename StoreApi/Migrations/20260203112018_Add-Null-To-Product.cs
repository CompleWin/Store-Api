using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class AddNullToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialTag",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Не принимаемых позиции практика степени модели формирования.", "https://picsum.photos/640/480/?image=287", "Интеллектуальный Неодимовый Компьютер", 221.38999999999999 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Позиции последовательного шагов следует реализация специалистов консультация создаёт.", "https://picsum.photos/640/480/?image=486", "Большой Деревянный Ножницы", 672.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Целесообразности с соответствующей разнообразный.", "https://picsum.photos/640/480/?image=143", "Потрясающий Кожанный Сабо", 135.63999999999999 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Нами собой активизации соображения забывать внедрения активизации участия административных.", "https://picsum.photos/640/480/?image=451", "Практичный Хлопковый Ремень", 349.67000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Активности модернизации широкому.", "https://picsum.photos/640/480/?image=626", "Великолепный Кожанный Стул", 43.229999999999997 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Мира важную забывать разнообразный широкому.", "https://picsum.photos/640/480/?image=41", "Свободный Неодимовый Куртка", 802.21000000000004 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Задания массового процесс.", "https://picsum.photos/640/480/?image=427", "Практичный Неодимовый Кошелек", 88.859999999999999, "Новинка" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Профессионального прежде насущным новая порядка организации структуры.", "https://picsum.photos/640/480/?image=824", "Грубый Меховой Носки", 189.03999999999999 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Соответствующей модели таким и соответствующей различных создаёт современного.", "https://picsum.photos/640/480/?image=435", "Великолепный Натуральный Портмоне", 48.259999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Уровня соответствующих базы предпосылки анализа задания вызывает участниками высокотехнологичная.", "https://picsum.photos/640/480/?image=741", "Практичный Меховой Стул", 531.55999999999995, "Новинка" });

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
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Социально-ориентированный формированию формировании.", "https://picsum.photos/640/480/?image=1038", "Лоснящийся Неодимовый Ремень", 551.66999999999996, "Новинка" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialTag",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Модернизации формирования влечёт формирования проблем сфера участия обеспечивает курс качественно.", "https://picsum.photos/640/480/?image=651", "Интеллектуальный Стальной Компьютер", 311.56999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Богатый прогрессивного значение определения нашей с шагов богатый.", "https://picsum.photos/640/480/?image=454", "Маленький Стальной Берет", 562.42999999999995, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Предпосылки этих модели значение нами же насущным шагов различных новых.", "https://picsum.photos/640/480/?image=966", "Свободный Кожанный Сабо", 885.21000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Инновационный дальнейших сознания для.", "https://picsum.photos/640/480/?image=145", "Маленький Кожанный Свитер", 274.60000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Социально-экономическое подготовке позиции демократической таким активом сомнений воздействия существующий разнообразный.", "https://picsum.photos/640/480/?image=151", "Практичный Деревянный Стул", 954.28999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Эксперимент активом рамки.", "https://picsum.photos/640/480/?image=394", "Великолепный Гранитный Стул", 948.77999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Важные а выбранный структуры постоянное анализа всего.", "https://picsum.photos/640/480/?image=216", "Практичный Гранитный Клатч", 542.37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "А концепция актуальность собой также.", "https://picsum.photos/640/480/?image=394", "Фантастический Бетонный Сабо", 802.42999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Разработке качественно а форм общественной.", "https://picsum.photos/640/480/?image=498", "Большой Деревянный Стул", 889.33000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Форм управление обуславливает по сомнений обеспечивает условий массового значимость организационной.", "https://picsum.photos/640/480/?image=910", "Практичный Неодимовый Стул", 138.06, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Кадровой показывает этих деятельности.", "https://picsum.photos/640/480/?image=421", "Интеллектуальный Гранитный Ножницы", 27.129999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Степени базы широким идейные.", "https://picsum.photos/640/480/?image=912", "Практичный Меховой Компьютер", 700.36000000000001, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Специалистов новых и начало материально-технической материально-технической.", "https://picsum.photos/640/480/?image=919", "Интеллектуальный Стальной Майка", 881.94000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Роль консультация также прогрессивного создание принципов нас существующий консультация богатый.", "https://picsum.photos/640/480/?image=440", "Практичный Деревянный Кулон", 823.46000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Создание формирования количественный определения богатый забывать этих.", "https://picsum.photos/640/480/?image=682", "Великолепный Деревянный Ножницы", 796.63, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "По роль обществом нами роль финансовых инновационный количественный широким.", "https://picsum.photos/640/480/?image=864", "Фантастический Бетонный Куртка", 587.30999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Потребностям принципов внедрения порядка реализация соответствующих обеспечение значение.", "https://picsum.photos/640/480/?image=303", "Фантастический Пластиковый Ботинок", 881.26999999999998, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Следует вызывает идейные рамки эксперимент.", "https://picsum.photos/640/480/?image=993", "Большой Пластиковый Стул", 292.38, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "По подготовке развития материально-технической высшего оценить.", "https://picsum.photos/640/480/?image=1000", "Великолепный Резиновый Майка", 623.00999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "И интересный нашей интересный определения существующий анализа.", "https://picsum.photos/640/480/?image=1031", "Свободный Гранитный Носки", 958.84000000000003, "Рекомендуемый" });
        }
    }
}
