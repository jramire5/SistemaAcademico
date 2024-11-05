using WebAPI.Reportes;
namespace WebAPI.EndPoints;

public static class ReportesEndpoints
{
    public static void MapReportesEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/runReport", async (string reportId, ReportRunner handler,IServiceProvider serviceProvider ) =>
        {
            byte[] arraybytes = await handler.RunReport(reportId, serviceProvider);

            return Results.File(arraybytes, "application/pdf", $"{ reportId }.pdf");
        });     
    }
}
