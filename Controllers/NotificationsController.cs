using MassTransit;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace MassTransitProducer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationsController : ControllerBase
{
    private readonly IPublishEndpoint _publishEndpoint;

    public NotificationsController(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost]
    public async Task<IActionResult> SendEmail(EmailDto email)
    {
        await _publishEndpoint.Publish<EmailMessage>(new
        {
            email.EmailAddress,
            email.ReceiverId,
            email.Subject,
            email.Body
        });

        return Ok();
    }
}
