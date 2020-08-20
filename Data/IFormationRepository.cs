using System.Collections.Generic;

namespace Data
{
    public interface IFormationRepository
    {
        List<Formation> GetFormations(int nombre);
        List<Formation> GetAllFormations();

        Formation getFormationById(int idFormation);
    }
}