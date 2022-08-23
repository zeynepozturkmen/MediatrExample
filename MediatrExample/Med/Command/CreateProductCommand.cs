using MediatR;

namespace MediatrExample.Med.Command
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {

                return Task.FromResult(Guid.NewGuid());

                //repo'da islem yapılmalı
            }
        }
    }
}
