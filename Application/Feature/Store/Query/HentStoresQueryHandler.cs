using AutoMapper;
using MediatR;
using Persistence.Repository;

namespace Application.Feature.Store.Query
{
    public class HentStoresQueryHandler : IRequestHandler<HentStoresQuery, List<HentStoresDto>>
    {
        private readonly IStoreRepository _repo;
        private readonly IMapper _mapper;

        public HentStoresQueryHandler(IStoreRepository repo, IMapper mapper)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<HentStoresDto>> Handle(HentStoresQuery request, CancellationToken cancellationToken)
        {
            var stores =  await _repo.GetAllStores();
            var mappedStoreList = _mapper.Map<List<HentStoresDto>>(stores);
            return mappedStoreList;
        }
    }

    public class HentStoresQuery : IRequest<List<HentStoresDto>>
    {
    }
}
