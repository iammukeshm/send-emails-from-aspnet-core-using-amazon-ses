using AmazonSES.Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmazonSES.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailsController : ControllerBase
    {
        private readonly IMailService _mailService;
        public MailsController(IMailService mailService)
        {
            this._mailService = mailService;
        }
        [HttpPost]
        public async Task<IActionResult> SendMail(MailRequest request)
        {
            await _mailService.SendEmailAsync(request);
            return Ok();
        }
    }
}
