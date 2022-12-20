using Fixxo.Data.Data;
using Fixxo.MVC.Services;


/* Vet inte om jag kanske gick ifrån instruktionerna lite grann med min projektuppbyggnad, men jag tyckte verkligen om det här mönstret och det följer grundtanken med solid bra tycker jag.
 * Det separerar ansvaret iaf. Jag hade nog velat ha det här i nosql, men fick inte till det med ef core. Hade jag haft tid hade jag nog gjort om det med ren nosql. Tack vare
 * arkitekturen skulle jag bara behöva ändra på Data projektet och kanske ett interface i core och sedan lägga till nosql. Den nosql som finns här var mot ef core.
 *
 *Jag hann inte bygga färdigt det här, men jag hoppas jag gett bra exempel på solid och dry principerna ändå.
 *
 */


/*  MY SOLID MANIFESTO
 *
 * S - Separate responsibility = varje fil ansvarar för "en sak"
 *
 * O - Open Close = Använd alltid interface så du kan förlänga klassen till en ny klass med interfacet, utan att behöva ändra ursprungsklassen. Gör listor med interface, inte klass.
 *                      Då kan man ha alla i listan som implementerar det interfacet, istället för bara en klass. Skriv klasser etc med utgångspunkten att de ska vara
 *                      "små och distinkta" och att du inte ska komma tillbaka och ändra de, utan förlänga istället.
 *
 * L - Liskow substitution = undvik onödiga och förvirrande arv. Subklass ska kunna lagras i föräldraklass  a la  BaseProduct product = new ProductInCatalog {...}
 *
 * I - Interface separation = (allt) ska ha ett eget interface som inte har överflödig funktion som används på andra platser
 *
 * D - Dependency Inversion = få bort alla initieringar runtomkring. Initiering ska endast ske på en plats i en factory ( kanske generic ). Klasser ur ett bibliotek
 *                              kan initieras, eftersom jag ändå inte kan gå in och ändra de. Använd dependency injection
 *
 * DRY - Don't repeat yourself = överväg generic factory, automapper, extensionmetoder. Skönt att slippa skriva extra men mest av allt - finns de bara på en plats
 *                              riskerar jag inte att ändra på en plats och glömma en annan
 *
 *
 */




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddData(builder.Configuration);
builder.Services.AddScoped<GetProductsService>();


// builder.Services.AddNoSqlData(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
