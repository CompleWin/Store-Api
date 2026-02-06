using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserIdToStringShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ShoppingCarts",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Сомнений постоянное обуславливает существующий.", "https://picsum.photos/640/480/?image=398", "Невероятный Меховой Компьютер", 963.02999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Порядка демократической нами для позволяет.", "https://picsum.photos/640/480/?image=26", "Грубый Хлопковый Берет", 236.78999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Создание структура организационной прогресса что нас работы порядка поэтапного.", "https://picsum.photos/640/480/?image=370", "Лоснящийся Неодимовый Стул", 934.66999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Прежде позиции дальнейшее прогресса обществом правительством собой порядка.", "https://picsum.photos/640/480/?image=308", "Лоснящийся Хлопковый Шарф", 568.46000000000004, "Новинка" });

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
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Обеспечивает а консультация целесообразности вызывает разнообразный.", "https://picsum.photos/640/480/?image=980", "Свободный Неодимовый Клатч", 824.88, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Социально-экономическое поставленных поставленных повседневной эксперимент социально-экономическое очевидна.", "https://picsum.photos/640/480/?image=787", "Эргономичный Неодимовый Ножницы", 851.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 2", "Сложившаяся кадров повышение повышение современного реализация прежде экономической управление.", "https://picsum.photos/640/480/?image=666", "Потрясающий Деревянный Компьютер", 639.97000000000003 });

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
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "И социально-ориентированный социально-ориентированный вызывает насущным дальнейших зависит.", "https://picsum.photos/640/480/?image=571", "Эргономичный Неодимовый Клатч", 202.91999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 4", "Занимаемых общественной рамки постоянное курс управление управление.", "https://picsum.photos/640/480/?image=87", "Свободный Стальной Портмоне", 591.92999999999995 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Высшего кадровой обучения задача.", "https://picsum.photos/640/480/?image=822", "Грубый Стальной Плащ", 112.59999999999999, "Рекомендуемый" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Место модель инновационный однако формирования технологий информационно-пропогандистское.", "https://picsum.photos/640/480/?image=15", "Эргономичный Резиновый Плащ", 715.88999999999999, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Настолько качественно важную постоянное внедрения позволяет прежде и.", "https://picsum.photos/640/480/?image=692", "Фантастический Стальной Клатч", 146.47, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Важные широким создаёт.", "https://picsum.photos/640/480/?image=135", "Великолепный Натуральный Плащ", 863.72000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 1", "Информационно-пропогандистское значимость порядка богатый сложившаяся формирования поэтапного задач поставленных.", "https://picsum.photos/640/480/?image=789", "Маленький Резиновый Берет", 775.25 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ShoppingCarts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Шагов плановых настолько степени.", "https://picsum.photos/640/480/?image=150", "Потрясающий Пластиковый Стол", 843.71000000000004 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Направлений сфера кадровой повседневной способствует важную особенности рост намеченных модернизации.", "https://picsum.photos/640/480/?image=866", "Потрясающий Меховой Ботинок", 632.70000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 5", "Эксперимент создаёт сомнений новая гражданского обществом.", "https://picsum.photos/640/480/?image=1020", "Грубый Пластиковый Свитер", 996.25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 4", "Прогрессивного рамки представляет поставленных соответствующей последовательного.", "https://picsum.photos/640/480/?image=288", "Практичный Пластиковый Ножницы", 861.32000000000005, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Правительством национальный укрепления задания повышению таким высшего.", "https://picsum.photos/640/480/?image=648", "Лоснящийся Хлопковый Клатч", 683.67999999999995, "Новинка" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Повседневная за не существующий принципов а.", "https://picsum.photos/640/480/?image=62", "Потрясающий Кожанный Ботинок", 177.55000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Обеспечение подготовке обеспечение систему социально-ориентированный структура базы равным.", "https://picsum.photos/640/480/?image=736", "Лоснящийся Натуральный Кошелек", 906.32000000000005 });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Социально-ориентированный уровня высшего работы изменений сознания позиции сознания.", "https://picsum.photos/640/480/?image=681", "Интеллектуальный Кожанный Клатч", 486.50999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 5", "Кругу кругу структуры анализа а условий социально-экономическое потребностям рост.", "https://picsum.photos/640/480/?image=999", "Свободный Пластиковый Куртка", 243.81, "Топ за свои деньги" });

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
                columns: new[] { "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Повышению уровня качественно.", "https://picsum.photos/640/480/?image=801", "Невероятный Натуральный Портмоне", 191.84999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Условий формировании систему позиции сложившаяся профессионального концепция от форм предпосылки.", "https://picsum.photos/640/480/?image=171", "Великолепный Стальной Стол", 93.849999999999994, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { "Поэтапного поэтапного начало позиции модернизации создание зависит однако участия материально-технической.", "https://picsum.photos/640/480/?image=534", "Грубый Меховой Майка", 864.98000000000002, "Топ за свои деньги" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Image", "Name", "Price" },
                values: new object[] { "Категория 3", "Влечёт демократической внедрения соображения соответствующих задания забывать прежде инновационный.", "https://picsum.photos/640/480/?image=631", "Интеллектуальный Неодимовый Шарф", 540.52999999999997 });
        }
    }
}
