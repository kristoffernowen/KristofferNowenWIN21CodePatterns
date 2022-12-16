using Fixxo.Data.Data;



/*  MY SOLID MANIFESTO
 *
 * S - Separate responsibility = varje fil ansvarar f�r "en sak"
 *
 * O - Open Close = Anv�nd alltid interface s� du kan f�rl�nga klassen till en ny klass med interfacet, utan att beh�va �ndra ursprungsklassen. G�r listor med interface, inte klass.
 *                      D� kan man ha alla i listan som implementerar det interfacet, ist�llet f�r bara en klass. Skriv klasser etc med utg�ngspunkten att de ska vara
 *                      "sm� och distinkta" och att du inte ska komma tillbaka och �ndra de, utan f�rl�nga ist�llet.
 *
 * L - Liskow substitution = undvik on�diga och f�rvirrande arv. Subklass ska kunna lagras i f�r�ldraklass  a la  BaseProduct product = new Product {...}
 *
 * I - Interface separation = (allt) ska ha ett eget interface som inte har �verfl�dig funktion som anv�nds p� andra platser
 *
 * D - Dependency Inversion = f� bort alla initieringar runtomkring. Initiering ska endast ske p� en plats i en factory ( kanske generic ). Klasser ur ett bibliotek
 *                              kan initieras, eftersom jag �nd� inte kan g� in och �ndra de. Anv�nd dependency injection
 *
 * DRY - Don't repeat yourself = �verv�g generic factory, automapper, extensionmetoder. Sk�nt att slippa skriva extra men mest av allt - finns de bara p� en plats
 *                              riskerar jag inte att �ndra p� en plats och gl�mma en annan
 *
 *
 */




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddData(builder.Configuration);



// builder.Services.AddNoSqlData(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
