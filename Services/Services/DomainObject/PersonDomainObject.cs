using Contracts.DTO;
using Contracts.Interfaces.IDomainObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services.DomainObject
{
    class PersonDomainObject : IPersonDomainObject
    {
        public int CreatePerson(PersonDTO person)
        {
            throw new NotImplementedException();
        }

        public int DeletePerson(int PersonId)
        {
            throw new NotImplementedException();
        }

        public List<PersonDTO> GetAllPerson()
        {
            throw new NotImplementedException();
        }

        public PersonDTO GetPersonPersonById()
        {
            throw new NotImplementedException();
        }

        public List<PersonDTO> GetPersonPersonByName()
        {
            throw new NotImplementedException();
        }

        public int UpdatePerson(PersonDTO person)
        {
            throw new NotImplementedException();
        }
    }
}
