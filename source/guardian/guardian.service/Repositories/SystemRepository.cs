using guardian.service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guardian.service.Repositories
{
    public class SystemRepository
    {
        private readonly GuardianContext _guardianContext;

        public SystemRepository(GuardianContext guardianContext)
        {
            _guardianContext = guardianContext;
        }

        public guardian.service.Models.System GetByName(string name)
        {
            return _guardianContext.Systems.SingleOrDefault(x => x.Name == name);
        }
    }
}
