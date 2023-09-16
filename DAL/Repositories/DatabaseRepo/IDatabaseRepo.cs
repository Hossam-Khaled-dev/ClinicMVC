using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.DAL;

public interface IDatabaseRepo
{
    public IDbContextTransaction Transaction();

}
