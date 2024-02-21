﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoDeLivros.Domain.Entities
{
    public sealed class UserEntity : BaseEntity
    {
        public string? Email { get; set; }
        public string? Name { get; set; }

    }
}
