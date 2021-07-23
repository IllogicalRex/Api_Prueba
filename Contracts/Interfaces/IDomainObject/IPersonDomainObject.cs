using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Interfaces.IDomainObject
{
    public interface IPersonDomainObject
    {
        int CreatePerson(PersonDTO person);
        List<PersonDTO> GetAllPerson();
        PersonDTO GetPersonPersonById();
        List<PersonDTO> GetPersonPersonByName();
        int DeletePerson(int PersonId);
        int UpdatePerson(PersonDTO person);
    }
}
