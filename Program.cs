var builder = WebApplication.CreateBuilder(args);

//Adding MVC
builder.Services.AddControllersWithViews(); // Register MVC services
var app = builder.Build();

app.MapGet("/", () => "Hello World!");//Minimal API endpoint

//Add MVC Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Adming/Login
//Guest/Welcome

app.Run();

//Step 1: Run this template as it is
//Step 2: Need to add MVC(HTML Page)
          //We will be adding MVC
          //Creating a controller
          //Creating a view
          //Running your application
