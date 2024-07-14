var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async context =>
{
    var path = context.Request.Path.ToString().ToLower();
    context.Response.ContentType = "text/html; charset=utf-8";

    if (path == "/biography")
    {
        await context.Response.WriteAsync(@"
            <html>
                <body style=""font-family: Arial, sans-serif; margin: 20px;"">
                    <h1 style=""color: navy; text-align: center;"">Біографія</h1>
                    <p style=""font-size: 18px; line-height: 1.6;"">
                        Мене звати Артем Скорих. Мені 17 років, я родом з Миколаєва. Моєю першою повноцінною навчальною установою була школа №18, де я навчався до кінця 9 класу. Після цього, у зв'язку з початком повномасштабної війни, я тимчасово емігрував до Івано-Франківської області, де продовжив своє навчання в іншому навчальному закладі - Ліцеї імені професора Александрова, де закінчив 10 та 11 класи дистанційно. Наразі я перебуваю в Німеччині, де закінчив дистанційне навчання в українському ліцеї і планую продовжити свою академічну діяльність уже тут.
                    </p>
                </body>
            </html>");
    }
    else if (path == "/portfolio")
    {
        await context.Response.WriteAsync(@"
            <html>
                <body style=""font-family: Arial, sans-serif; margin: 20px;"">
                    <h1 style=""color: navy; text-align: center;"">Портфоліо</h1>
                    <div style=""margin: 20px 0;"">
                        <h2 style=""color: darkslategray;"">Освіта</h2>
                        <ul style=""list-style-type: square;"">
                            <li>Школа №18, Миколаїв - до 9 класу</li>
                            <li>Ліцей імені професора Александрова, Миколаївська область - 10 та 11 класи (дистанційно)</li>
                        </ul>
                    </div>
                    <div style=""margin: 20px 0;"">
                        <h2 style=""color: darkslategray;"">Навички</h2>
                        <ul style=""list-style-type: square;"">
                            <li>Дистанційне навчання</li>
                            <li>Адаптація до нових умов</li>
                            <li>Самоорганізація</li>
                        </ul>
                    </div>
                    <div style=""margin: 20px 0;"">
                        <h2 style=""color: darkslategray;"">Плани на майбутнє</h2>
                        <p style=""font-size: 18px; line-height: 1.6;"">
                            Планую продовжити свою академічну діяльність у Німеччині, здобуваючи нові знання та навички для успішного майбутнього.
                        </p>
                    </div>
                </body>
            </html>");
    }
    else
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync($"<h1 style='color:red'>Not found</h1>");
    }
});

app.Run();
