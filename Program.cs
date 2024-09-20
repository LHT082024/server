var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



//brukes til å hente de andre filene
// app.UseDefaultFiles();
// app.UseStaticFiles();

//bare for å ha noe på åpnings siden. 
app.MapGet("/", () => "Hello World!");


// //husker ikke hvordan eg sjekket denne engang lol.
app.MapGet("/health", () => 
{
   return "server a okay lol"; 
}
);


app.Run();

