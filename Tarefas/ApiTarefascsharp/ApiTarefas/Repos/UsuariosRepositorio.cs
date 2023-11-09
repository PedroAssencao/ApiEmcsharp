using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Repos
{
    public class UsuariosRepositorio : BaseRepository<Usuario>
    {
        public UsuariosRepositorio(SistemaTarefasDBcontext SistemaTarefasDBcontext) : base(SistemaTarefasDBcontext)
        {
        }

    }
}
