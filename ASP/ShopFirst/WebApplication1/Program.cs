using WebApplication1;
using WebApplication1.Data.interfaces;
using WebApplication1.Data.Moks;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddRazorPages();

builder.Services.AddMvc();
builder.Services.AddTransient<IAllCars, MockCars>(); //����� ����� � ����� �������� ��������� 
builder.Services.AddTransient<ICarsCategory, MockCategory>();



var app = builder.Build();

app.UseDeveloperExceptionPage();//��� ����������� ������
app.UseStatusCodePages(); //��� ����������� ����� ��� (404)
app.UseStaticFiles();//��� �������� � ��
//app.UseMvcWithDefaultRoute(); //����������� url ������ �� ���������

//app.MapGet("/", () => "Hello World!");

app.Run(async (context) =>
{
    var response = context.Response;
    response.ContentType = "text/html; charset=utf-8";
    await response.WriteAsync("<h2>Hello METANIT.COM</h2><h3>Welcome to ASP.NET Core</h3>");
});


app.Run();

