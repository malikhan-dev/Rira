using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Registerations.Repositories
{
    public interface IRegisterationCommandRepository
    {
        Task Add(Registeration registeration, CancellationToken token);
        Task Remove(int id, CancellationToken token);
        Task Update(Registeration registeration, CancellationToken token);
    }
}
