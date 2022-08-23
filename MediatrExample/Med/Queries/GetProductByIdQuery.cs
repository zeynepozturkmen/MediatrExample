using MediatR;

namespace MediatrExample.Med.Queries
{
    //GetProductByIdViewModel dönecegini belirtiyor
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
