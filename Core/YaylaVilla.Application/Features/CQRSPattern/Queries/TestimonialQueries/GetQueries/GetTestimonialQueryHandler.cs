using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TestimonialRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.GetQueries
{
    internal class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQueryRepuest, GetTestimonialQueryResponse>
    {
        private readonly ITestimonialReadRepository _testimonialReadRepository;
        private readonly IMapper _mapper;

        public GetTestimonialQueryHandler(ITestimonialReadRepository testimonialReadRepository, IMapper mapper)
        {
            _testimonialReadRepository = testimonialReadRepository;
            _mapper = mapper;
        }

        public async Task<GetTestimonialQueryResponse> Handle(GetTestimonialQueryRepuest request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetTestimonialQueryResponse>(await _testimonialReadRepository.GetByIDAsync(request.id));
            return value;
        }
    }
}
