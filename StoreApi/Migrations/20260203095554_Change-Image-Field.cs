using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImageField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "Image");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Модернизации формирования влечёт формирования проблем сфера участия обеспечивает курс качественно.", "https://picsum.photos/640/480/?image=651", "Интеллектуальный Стальной Компьютер", 311.56999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Богатый прогрессивного значение определения нашей с шагов богатый.", "https://picsum.photos/640/480/?image=454", "Маленький Стальной Берет", 562.42999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Предпосылки этих модели значение нами же насущным шагов различных новых.", "https://picsum.photos/640/480/?image=966", "Свободный Кожанный Сабо", 885.21000000000004, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Инновационный дальнейших сознания для.", "https://picsum.photos/640/480/?image=145", "Маленький Кожанный Свитер", 274.60000000000002, "Топ за свои деньги" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Эксперимент активом рамки.", "https://picsum.photos/640/480/?image=394", "Великолепный Гранитный Стул", 948.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Важные а выбранный структуры постоянное анализа всего.", "https://picsum.photos/640/480/?image=216", "Практичный Гранитный Клатч", 542.37, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "А концепция актуальность собой также.", "https://picsum.photos/640/480/?image=394", "Фантастический Бетонный Сабо", 802.42999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Разработке качественно а форм общественной.", "https://picsum.photos/640/480/?image=498", "Большой Деревянный Стул", 889.33000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Форм управление обуславливает по сомнений обеспечивает условий массового значимость организационной.", "https://picsum.photos/640/480/?image=910", "Практичный Неодимовый Стул", 138.06, "Новинка" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Степени базы широким идейные.", "https://picsum.photos/640/480/?image=912", "Практичный Меховой Компьютер", 700.36000000000001, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Специалистов новых и начало материально-технической материально-технической.", "https://picsum.photos/640/480/?image=919", "Интеллектуальный Стальной Майка", 881.94000000000005, "Топ за свои деньги" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "По роль обществом нами роль финансовых инновационный количественный широким.", "https://picsum.photos/640/480/?image=864", "Фантастический Бетонный Куртка", 587.30999999999995, "Новинка" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Следует вызывает идейные рамки эксперимент.", "https://picsum.photos/640/480/?image=993", "Большой Пластиковый Стул", 292.38 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "И интересный нашей интересный определения существующий анализа.", "https://picsum.photos/640/480/?image=1031", "Свободный Гранитный Носки", 958.84000000000003 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "ImageUrl");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Практика уточнения в шагов.", "https://picsum.photos/640/480/?image=7", "Невероятный Деревянный Кошелек", 795.84000000000003, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Категория 5", "Качества создание постоянное отношении же мира порядка.", "https://picsum.photos/640/480/?image=1019", "Грубый Стальной Автомобиль", 343.12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Практика формировании путь.", "https://picsum.photos/640/480/?image=1052", "Потрясающий Натуральный Кулон", 657.48000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Кадров процесс повышение.", "https://picsum.photos/640/480/?image=138", "Потрясающий Кожанный Куртка", 447.14999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Категория 5", "Поэтапного отметить качества целесообразности.", "https://picsum.photos/640/480/?image=312", "Большой Гранитный Стул", 344.68000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Категория 2", "Прогресса интересный современного разнообразный сомнений массового поставленных.", "https://picsum.photos/640/480/?image=285", "Грубый Неодимовый Свитер", 513.25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Постоянное новых существующий другой курс активом задача очевидна.", "https://picsum.photos/640/480/?image=505", "Потрясающий Натуральный Носки", 888.26999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Структуры уровня количественный.", "https://picsum.photos/640/480/?image=704", "Свободный Деревянный Шарф", 314.29000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Повышение позиции влечёт модернизации сфера гражданского разработке повседневной однако поставленных.", "https://picsum.photos/640/480/?image=726", "Свободный Натуральный Шарф", 161.61000000000001, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Понимание поэтапного информационно-пропогандистское.", "https://picsum.photos/640/480/?image=754", "Свободный Натуральный Плащ", 534.51999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Развития формировании создаёт.", "https://picsum.photos/640/480/?image=598", "Эргономичный Кожанный Плащ", 126.05, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Прогрессивного плановых сложившаяся требует задач.", "https://picsum.photos/640/480/?image=508", "Великолепный Меховой Клатч", 560.96000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Модернизации рост изменений.", "https://picsum.photos/640/480/?image=617", "Невероятный Кожанный Компьютер", 183.88999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Категория 4", "Реализация сложившаяся играет эксперимент сложившаяся.", "https://picsum.photos/640/480/?image=977", "Лоснящийся Натуральный Ножницы", 428.29000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Общественной структуры нашей уровня настолько материально-технической.", "https://picsum.photos/640/480/?image=1076", "Практичный Неодимовый Куртка", 286.57999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Проблем путь нашей правительством задача подготовке собой стороны гражданского выбранный.", "https://picsum.photos/640/480/?image=966", "Интеллектуальный Хлопковый Кулон", 515.35000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Формировании представляет сомнений сущности подготовке существующий прежде.", "https://picsum.photos/640/480/?image=239", "Практичный Резиновый Ножницы", 222.05000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Категория 5", "Проблем формирования отметить позволяет проверки занимаемых от способствует требует.", "https://picsum.photos/640/480/?image=306", "Практичный Неодимовый Кулон", 605.13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Воздействия оценить богатый с укрепления курс целесообразности современного.", "https://picsum.photos/640/480/?image=42", "Великолепный Меховой Кулон", 285.04000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Категория 5", "Воздействия практика структура организационной современного.", "https://picsum.photos/640/480/?image=339", "Грубый Бетонный Плащ", 84.299999999999997 });
        }
    }
}
