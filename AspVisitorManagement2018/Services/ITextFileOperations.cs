using System.Collections.Generic;

namespace AspVisitorManagement2018.Services
{
    public interface ITextFileOperations
    {
        IEnumerable<string> LoadConditionsForAcceptanceText();
    }
}