using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductView>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductView>>
        {
            public Task<List<GetProductView>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductView()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                };
                var model2 = new GetProductView()
                {
                    Id = Guid.NewGuid(),
                    Name = "Monitor"
                };
                return Task.FromResult(new List<GetProductView>() {model,model2});
            }
        }
    }
}
