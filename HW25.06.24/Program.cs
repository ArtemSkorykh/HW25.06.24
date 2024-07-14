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
                    <h1 style=""color: navy; text-align: center;"">���������</h1>
                    <p style=""font-size: 18px; line-height: 1.6;"">
                        ���� ����� ����� ������. ��� 17 ����, � ����� � ��������. ��� ������ ����������� ���������� ��������� ���� ����� �18, �� � �������� �� ���� 9 �����. ϳ��� �����, � ��'���� � �������� �������������� ����, � ��������� �������� �� �����-���������� ������, �� ��������� ��� �������� � ������ ����������� ������ - ˳�� ���� ��������� ������������, �� ������� 10 �� 11 ����� �����������. ����� � ��������� � ͳ������, �� ������� ����������� �������� � ����������� ��� � ������ ���������� ���� ��������� �������� ��� ���.
                    </p>
                </body>
            </html>");
    }
    else if (path == "/portfolio")
    {
        await context.Response.WriteAsync(@"
            <html>
                <body style=""font-family: Arial, sans-serif; margin: 20px;"">
                    <h1 style=""color: navy; text-align: center;"">��������</h1>
                    <div style=""margin: 20px 0;"">
                        <h2 style=""color: darkslategray;"">�����</h2>
                        <ul style=""list-style-type: square;"">
                            <li>����� �18, ������� - �� 9 �����</li>
                            <li>˳��� ���� ��������� ������������, ����������� ������� - 10 �� 11 ����� (�����������)</li>
                        </ul>
                    </div>
                    <div style=""margin: 20px 0;"">
                        <h2 style=""color: darkslategray;"">�������</h2>
                        <ul style=""list-style-type: square;"">
                            <li>����������� ��������</li>
                            <li>��������� �� ����� ����</li>
                            <li>��������������</li>
                        </ul>
                    </div>
                    <div style=""margin: 20px 0;"">
                        <h2 style=""color: darkslategray;"">����� �� �������</h2>
                        <p style=""font-size: 18px; line-height: 1.6;"">
                            ������ ���������� ���� ��������� �������� � ͳ������, ���������� ��� ������ �� ������� ��� �������� �����������.
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