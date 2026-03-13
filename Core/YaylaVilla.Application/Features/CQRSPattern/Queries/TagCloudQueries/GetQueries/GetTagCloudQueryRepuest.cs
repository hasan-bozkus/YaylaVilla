using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.GetQueries
{
    public class GetTagCloudQueryRepuest : IRequest<GetTagCloudQueryResponse>
    {
        public int id { get; set; }
    }
}