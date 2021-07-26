using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Parson>
    {
        private readonly IDataAccess _data;
        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;

        }
        public Task<Parson> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertParson(request.FirstName,request.LastName));
        }
    }
}