using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class AddFakerProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Категория 3", "Практика уточнения в шагов.", "https://picsum.photos/640/480/?image=7", "Невероятный Деревянный Кошелек", 795.84000000000003, "Топ за свои деньги" },
                    { 2, "Категория 5", "Качества создание постоянное отношении же мира порядка.", "https://picsum.photos/640/480/?image=1019", "Грубый Стальной Автомобиль", 343.12, "Топ за свои деньги" },
                    { 3, "Категория 5", "Практика формировании путь.", "https://picsum.photos/640/480/?image=1052", "Потрясающий Натуральный Кулон", 657.48000000000002, "Новинка" },
                    { 4, "Категория 1", "Кадров процесс повышение.", "https://picsum.photos/640/480/?image=138", "Потрясающий Кожанный Куртка", 447.14999999999998, "Рекомендуемый" },
                    { 5, "Категория 5", "Поэтапного отметить качества целесообразности.", "https://picsum.photos/640/480/?image=312", "Большой Гранитный Стул", 344.68000000000001, "Топ за свои деньги" },
                    { 6, "Категория 2", "Прогресса интересный современного разнообразный сомнений массового поставленных.", "https://picsum.photos/640/480/?image=285", "Грубый Неодимовый Свитер", 513.25, "Рекомендуемый" },
                    { 7, "Категория 2", "Постоянное новых существующий другой курс активом задача очевидна.", "https://picsum.photos/640/480/?image=505", "Потрясающий Натуральный Носки", 888.26999999999998, "Новинка" },
                    { 8, "Категория 1", "Структуры уровня количественный.", "https://picsum.photos/640/480/?image=704", "Свободный Деревянный Шарф", 314.29000000000002, "Топ за свои деньги" },
                    { 9, "Категория 5", "Повышение позиции влечёт модернизации сфера гражданского разработке повседневной однако поставленных.", "https://picsum.photos/640/480/?image=726", "Свободный Натуральный Шарф", 161.61000000000001, "Топ за свои деньги" },
                    { 10, "Категория 3", "Понимание поэтапного информационно-пропогандистское.", "https://picsum.photos/640/480/?image=754", "Свободный Натуральный Плащ", 534.51999999999998, "Рекомендуемый" },
                    { 11, "Категория 5", "Развития формировании создаёт.", "https://picsum.photos/640/480/?image=598", "Эргономичный Кожанный Плащ", 126.05, "Новинка" },
                    { 12, "Категория 4", "Прогрессивного плановых сложившаяся требует задач.", "https://picsum.photos/640/480/?image=508", "Великолепный Меховой Клатч", 560.96000000000004, "Новинка" },
                    { 13, "Категория 3", "Модернизации рост изменений.", "https://picsum.photos/640/480/?image=617", "Невероятный Кожанный Компьютер", 183.88999999999999, "Рекомендуемый" },
                    { 14, "Категория 4", "Реализация сложившаяся играет эксперимент сложившаяся.", "https://picsum.photos/640/480/?image=977", "Лоснящийся Натуральный Ножницы", 428.29000000000002, "Новинка" },
                    { 15, "Категория 2", "Общественной структуры нашей уровня настолько материально-технической.", "https://picsum.photos/640/480/?image=1076", "Практичный Неодимовый Куртка", 286.57999999999998, "Рекомендуемый" },
                    { 16, "Категория 2", "Проблем путь нашей правительством задача подготовке собой стороны гражданского выбранный.", "https://picsum.photos/640/480/?image=966", "Интеллектуальный Хлопковый Кулон", 515.35000000000002, "Топ за свои деньги" },
                    { 17, "Категория 5", "Формировании представляет сомнений сущности подготовке существующий прежде.", "https://picsum.photos/640/480/?image=239", "Практичный Резиновый Ножницы", 222.05000000000001, "Рекомендуемый" },
                    { 18, "Категория 5", "Проблем формирования отметить позволяет проверки занимаемых от способствует требует.", "https://picsum.photos/640/480/?image=306", "Практичный Неодимовый Кулон", 605.13, "Рекомендуемый" },
                    { 19, "Категория 3", "Воздействия оценить богатый с укрепления курс целесообразности современного.", "https://picsum.photos/640/480/?image=42", "Великолепный Меховой Кулон", 285.04000000000002, "Новинка" },
                    { 20, "Категория 5", "Воздействия практика структура организационной современного.", "https://picsum.photos/640/480/?image=339", "Грубый Бетонный Плащ", 84.299999999999997, "Рекомендуемый" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
