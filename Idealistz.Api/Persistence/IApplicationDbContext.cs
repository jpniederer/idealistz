using System;
using Microsoft.EntityFrameworkCore;
using Idealistz.Api.Core.Entities;

namespace Idealistz.Api.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Idea> Ideas { get; set; }
    }
}
