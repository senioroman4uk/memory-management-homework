using System.Collections.Generic;
using System.Threading.Tasks;
using MemoryManagementHomeWork.Contracts;
using MessagesClient;
using Microsoft.AspNetCore.Mvc;

namespace MemoryManagementHomeWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageClient _messageClient;

        public MessagesController(IMessageClientFactory messageClientFactory)
        {
            _messageClient = messageClientFactory.Create();
        }

        // GET api/messages
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }
        
        // POST api/messages
        [HttpPost]
        public async Task Post([FromBody] string value)
        {
            await _messageClient.SendMessageAsync(new Message
            {
                Content = value
            });
        }
        
    }
}