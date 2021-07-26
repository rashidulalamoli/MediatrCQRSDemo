using System.Collections.Generic;
using System.Threading;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using DemoLibrary.DataAccess;
using MediatR;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetParsonListHandler : IRequestHandler<GetParsonListQuery, List<Parson>>
    {
        private readonly IDataAccess _data;
        public GetParsonListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<Parson>> Handle(GetParsonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetPeople());
        }
    }
}