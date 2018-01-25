﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteDISample.Models
{
    public interface IUnitOfWork:IDisposable
    {
        void Commit();
    }
}