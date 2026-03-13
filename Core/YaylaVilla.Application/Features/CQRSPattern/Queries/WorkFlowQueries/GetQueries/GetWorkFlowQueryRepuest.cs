using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.GetQueries
{
    public class GetWorkFlowQueryRepuest : IRequest<GetWorkFlowQueryResponse>
    {
        public int id { get; set; }
    }
}