using scrollFrame.DataAccess;
using scrollFrame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace scrollFrame.Services
{
    public class PersonaServices
    {
        PersonaDAO personaDAO;

        public PersonaServices()
        {
            personaDAO = new PersonaDAO();
        }

        public void createPerson(PersonaModel personaModel)
        {
            personaDAO.create(personaModel);
        }

        public List<PersonaModel> listPerson()
        {
            return personaDAO.list();
        }
    }
}
