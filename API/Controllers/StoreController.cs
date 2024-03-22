using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Feature.Store;
using Application.Feature.Store.Query;

namespace API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<StoreController> _logger;

        public StoreController(IMediator mediator, ILogger<StoreController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<ActionResult<List<HentStoresDto>>> HentList()
        {
            var stores = await _mediator.Send(new HentStoresQuery());
            return stores;
        }
    }
}
