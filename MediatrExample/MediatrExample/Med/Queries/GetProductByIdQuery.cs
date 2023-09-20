using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductView>
    {
        public Guid Id  { get; set; }
    }
}
