#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    return new OkObjectResult("Server=tcp:holidayhangovervulnerableserver.database.windows.net,1433;Initial Catalog=holidayhangovervulnerabledb;Persist Security Info=False;User ID=DevOps;Password=holidayhangover{C0NN3CT10N_STR1NG};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
}
