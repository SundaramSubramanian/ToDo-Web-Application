using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo_Simple_Web_Application.Interface;
using ToDo_Simple_Web_Application.Repository;

namespace ToDo_Simple_Web_Application.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationService()
        {
            _registrationRepository = new RegistrationRepository();
        }
    }
}
