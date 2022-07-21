using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoTeste
{
    private readonly Mock<DbSet<Categoria>> mockSet;
    private readonly Mock<Context> mockContext;
    private readonly Categoria categoria;

    class CategoriaConytrollerTeste
    {
        _mockSet = new Mock<DbSet<Categoria>>();
        _mokContext = new Mock<Context>();
        _categoria = new Categoria {id = 1, Descricao = "Teste Categoria"}

    }
}
