using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Features.Products.Events
{
    public class SendMessageNotification : INotification
    {
        public string Address { get; }
        public string Content { get; }
        public SendMessageNotification(string emailAddress, string emailContent)
        {
            Address = emailAddress;
            Content = emailContent;
        }
        public class EmailNotificationHandler : INotificationHandler<SendMessageNotification>
        {
            private readonly ILogger<EmailNotificationHandler> _logger;

            public EmailNotificationHandler(ILogger<EmailNotificationHandler> logger)
            {
                _logger = logger;
            }

            public Task Handle(SendMessageNotification notification, CancellationToken cancellationToken)
            {
                _logger.LogWarning($"Sending Email to {notification.Address} with content {notification.Content}");
                return Task.CompletedTask;
            }
        }

        public class SmsNotificationHandler : INotificationHandler<SendMessageNotification>
        {
            private readonly ILogger<EmailNotificationHandler> _logger;

            public SmsNotificationHandler(ILogger<EmailNotificationHandler> logger)
            {
                _logger = logger;
            }

            public Task Handle(SendMessageNotification notification, CancellationToken cancellationToken)
            {
                _logger.LogWarning($"Sending SMS to {notification.Address} with content {notification.Content}");
                return Task.CompletedTask;
            }
        }
    }
}
