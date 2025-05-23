
namespace HangfireEmails.Service
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            Console.WriteLine($"[Email enviado] Para: {to} | Assunto: {subject}");
            await Task.Delay(1000); // simula tempo de envio
        }
    }
}
