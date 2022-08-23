using MediatR;

namespace MediatrExample.Med.Queries
{
    // IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
    //GetProductByIdQuery =request
    //GetProductByIdViewModel =response 
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(viewModel);

            //get product from repo
        }
    }
}
