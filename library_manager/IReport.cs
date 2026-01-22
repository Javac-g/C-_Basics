using System.Threading.Tasks;
using System.Collections.Generic;

public interface IReport
{
    Task GenerateReportAsync(List<Book> books);
}
