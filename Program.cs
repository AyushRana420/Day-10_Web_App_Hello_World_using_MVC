var builder = WebApplication.CreateBuilder(args);

//Adding MVC
builder.Services.AddControllersWithViews(); // Register MVC services
var app = builder.Build();

app.MapGet("/", () => "Hello World!");//Minimal API endpoint

//Ex1: Returning a list (Hard Coded)
//Here i am testing endpoint
app.MapGet("/Mobilephones", () => new List<string> { "Samsung", "Oneplus", "Apple" });

//Ex2: Returning a Dynamic List(Query Parameters)
app.MapGet("/RepeatNames", (string name, int count) => Enumerable.Repeat(name, count).ToList());

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
