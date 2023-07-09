var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDeveloperExceptionPage();//для отображения ошибок
app.UseStatusCodePages(); //для отображение кодов стр (404)
app.UseStaticFiles();//для картинок и тд
app.UseMvcWithDefaultRoute(); //отображение url адреса по умолчанию

//app.MapGet("/", () => "Hello World!");

app.Run(async (context) =>
{
    var response = context.Response;
    response.ContentType = "text/html; charset=utf-8";
    await response.WriteAsync("<h2>Hello METANIT.COM</h2><h3>Welcome to ASP.NET Core</h3>");
});


app.Run();

