using System.Collections.Generic;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetParsonListQuery() : IRequest<List<Parson>>;
}