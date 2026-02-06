using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusToOrderHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "OrderHeaders",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Воздействия организационной вызывает.", "https://picsum.photos/640/480/?image=107", "Эргономичный Натуральный Стол", 83.480000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Активизации модели инновационный позиции профессионального участия опыт.", "https://picsum.photos/640/480/?image=45", "Потрясающий Стальной Кошелек", 616.25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Развития демократической различных инновационный позиции активом повседневной всего.", "https://picsum.photos/640/480/?image=1026", "Грубый Неодимовый Носки", 807.75999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Мира практика ресурсосберегающих.", "https://picsum.photos/640/480/?image=355", "Великолепный Гранитный Куртка", 320.55000000000001, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Идейные насущным способствует задания определения направлений модели социально-экономическое.", "https://picsum.photos/640/480/?image=294", "Фантастический Бетонный Кулон", 232.78999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Отношении форм же также.", "https://picsum.photos/640/480/?image=157", "Фантастический Пластиковый Носки", 376.22000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Намеченных задач прогресса мира задач другой эксперимент принципов следует.", "https://picsum.photos/640/480/?image=327", "Эргономичный Меховой Портмоне", 452.81999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Базы что выполнять а равным.", "https://picsum.photos/640/480/?image=125", "Практичный Деревянный Стол", 766.00999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Выполнять организации модель.", "https://picsum.photos/640/480/?image=870", "Маленький Меховой Кошелек", 97.590000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Развития обуславливает от следует поэтапного напрямую значительной выбранный.", "https://picsum.photos/640/480/?image=69", "Лоснящийся Гранитный Автомобиль", 921.88999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Существующий предпосылки выбранный мира ресурсосберегающих очевидна обеспечивает задания.", "https://picsum.photos/640/480/?image=749", "Большой Меховой Плащ", 554.69000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Повышение всего сущности социально-ориентированный соответствующих особенности постоянное работы зависит.", "https://picsum.photos/640/480/?image=283", "Интеллектуальный Пластиковый Плащ", 802.73000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Модернизации уточнения постоянный интересный значимость принимаемых не способствует.", "https://picsum.photos/640/480/?image=365", "Практичный Резиновый Берет", 347.73000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "На соответствующей принципов на.", "https://picsum.photos/640/480/?image=343", "Маленький Хлопковый Компьютер", 257.22000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Показывает предложений дальнейших по.", "https://picsum.photos/640/480/?image=206", "Практичный Натуральный Сабо", 29.989999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Разработке широкому национальный прогресса развития повышению нашей выполнять.", "https://picsum.photos/640/480/?image=396", "Интеллектуальный Натуральный Клатч", 375.06999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Представляет участия дальнейшее развития кадров.", "https://picsum.photos/640/480/?image=1062", "Маленький Неодимовый Клатч", 880.48000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "С порядка значительной идейные значительной рост создаёт.", "https://picsum.photos/640/480/?image=890", "Маленький Стальной Автомобиль", 412.88, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Социально-экономическое сознания забывать сущности.", "https://picsum.photos/640/480/?image=299", "Великолепный Кожанный Шарф", 858.53999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Дальнейшее забывать финансовых роль финансовых всего общества прогрессивного важные гражданского.", "https://picsum.photos/640/480/?image=269", "Невероятный Меховой Ботинок", 480.19999999999999 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrderHeaders");

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Повседневной финансовых за.", "https://picsum.photos/640/480/?image=579", "Великолепный Бетонный Куртка", 739.49000000000001, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Технологий по оценить.", "https://picsum.photos/640/480/?image=98", "Невероятный Хлопковый Клатч", 213.55000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Важные целесообразности занимаемых работы общественной значимость.", "https://picsum.photos/640/480/?image=773", "Невероятный Стальной Стул", 453.38, "Новинка" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Сомнений базы интересный укрепления.", "https://picsum.photos/640/480/?image=749", "Маленький Бетонный Майка", 840.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Забывать социально-экономическое предпосылки процесс активом идейные мира.", "https://picsum.photos/640/480/?image=952", "Грубый Хлопковый Стул", 505.02999999999997, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Последовательного показывает опыт массового напрямую форм.", "https://picsum.photos/640/480/?image=739", "Свободный Стальной Носки", 621.45000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Форм кадров определения работы массового модель различных гражданского внедрения.", "https://picsum.photos/640/480/?image=564", "Эргономичный Резиновый Майка", 642.83000000000004, "Топ за свои деньги" });

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
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Рост насущным социально-ориентированный особенности информационно-пропогандистское образом.", "https://picsum.photos/640/480/?image=1021", "Большой Меховой Кулон", 35.740000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Участниками показывает активизации требует таким намеченных дальнейших от.", "https://picsum.photos/640/480/?image=846", "Свободный Меховой Компьютер", 463.70999999999998 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Дальнейших активом в намеченных эксперимент повседневная специалистов показывает.", "https://picsum.photos/640/480/?image=187", "Невероятный Пластиковый Ножницы", 187.25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Позиции кадров сущности.", "https://picsum.photos/640/480/?image=580", "Невероятный Неодимовый Стул", 491.68000000000001, "Топ за свои деньги" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Участия нами активом.", "https://picsum.photos/640/480/?image=789", "Грубый Хлопковый Клатч", 744.49000000000001 });
        }
    }
}
