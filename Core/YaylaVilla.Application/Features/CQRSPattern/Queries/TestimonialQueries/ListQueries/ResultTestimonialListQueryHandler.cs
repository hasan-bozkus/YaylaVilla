using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaylaVilla.Application.Features.RepositoryPattern.Abstract.TestimonialRepositories;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.ListQueries
{
    internal class ResultTestimonialListQueryHandler : IRequestHandler<ResultTestimonialListQueryRequest, List<ResultTestimonialListQueryResponse>>
    {
        private readonly ITestimonialReadRepository _testimonialReadRepository;
        private readonly IMapper _mapper;

        public ResultTestimonialListQueryHandler(ITestimonialReadRepository testimonialReadRepository, IMapper mapper)
        {
            _testimonialReadRepository = testimonialReadRepository;
            _mapper = mapper;
        }

        public async Task<List<ResultTestimonialListQueryResponse>> Handle(ResultTestimonialListQueryRequest request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<List<ResultTestimonialListQueryResponse>>(await _testimonialReadRepository.GetListAllAsync());
            return values;
        }
    }
}
