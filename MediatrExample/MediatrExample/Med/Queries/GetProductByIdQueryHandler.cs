using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductView>
    {
        public async Task<GetProductView> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductView()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };
            return await Task.FromResult(viewModel);
            //Get Product From repository 

        }
    }
}
