﻿using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Arquitetura.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConn();
    }
}
