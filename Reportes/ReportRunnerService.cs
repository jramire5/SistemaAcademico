using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Reportes.Definicion;

namespace Reportes.Services;

public class ReportRunnerService
{
    public byte[] RunReport(string REPORT_ID, object data)
    {
        IDocument document;
        switch (REPORT_ID)
        {
            case "CURSOS":
                document = new ReporteCursos(data);
                // Define the file path
                // string filePath = Path.Combine("C:\\cerealvb\\PDF\\", "CCPesosReport.pdf");
              //  string serverFileName = System.Guid.NewGuid().ToString() + "." + archDef.arc_extension;
               // string filePath = Path.Combine(archDef.arc_path, serverFileName);

                // Save the PDF to the specified folder path
                return document.GeneratePdf();
            case "PLANES":
                document = new ReportePlanes(data);
                // Define the file path
                // string filePath = Path.Combine("C:\\cerealvb\\PDF\\", "CCPesosReport.pdf");
                //  string serverFileName = System.Guid.NewGuid().ToString() + "." + archDef.arc_extension;
                // string filePath = Path.Combine(archDef.arc_path, serverFileName);

                // Save the PDF to the specified folder path
                return document.GeneratePdf();
                
        }

        throw new NotImplementedException();
    }
}
