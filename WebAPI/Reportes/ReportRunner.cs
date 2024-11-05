using Domain.Services;
using Reportes.Services;

namespace WebAPI.Reportes;

public class ReportRunner
{
    public async Task<byte[]> RunReport(string REPORT_ID, IServiceProvider serviceProvider)
    {
        ReportRunnerService reportRunner = new ReportRunnerService();
        switch (REPORT_ID)
        {
            case "CURSOS":
                //Get Data
                CursoService cursoService = serviceProvider.GetRequiredService<CursoService>();
                return reportRunner.RunReport(REPORT_ID, await cursoService.GetAll());

            case "PLANES":
                PlanService planService= serviceProvider.GetRequiredService<PlanService>();
                return reportRunner.RunReport(REPORT_ID, await planService.GetAll());               

        }

        throw new NotImplementedException();
    }
}
