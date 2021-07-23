using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces.IDAO
{
    public interface IPersonDAO
    {
        int CreatePerson(PersonDTO person);
        List<PersonDTO> GetAllPerson(int role);
        PersonDTO GetPersonPersonById();
        List<PersonDTO> GetPersonPersonByName();
        int DeletePerson(int PersonId);
        int UpdatePerson(PersonDTO person);
    }
}
