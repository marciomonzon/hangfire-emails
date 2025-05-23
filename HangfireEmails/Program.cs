using Hangfire;
using Hangfire.MemoryStorage;
using HangfireEmails.DTO;
using HangfireEmails.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHangfire(config =>
    config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
          .UseSimpleAssemblyNameTypeSerializer()
          .UseRecommendedSerializerSettings()
          .UseMemoryStorage());

builder.Services.AddHangfireServer();
builder.Services.AddSingleton<IEmailService, EmailService>();

var app = builder.Build();

app.UseHangfireDashboard("/hangfire");

app.MapGet("/", () => "API de Agendamento de E-mails com Hangfire");

RecurringJob.AddOrUpdate<IEmailService>(
    x => x.SendEmailAsync("admin@site.com", "Relatório diário", "Conteúdo..."),
    Cron.Monthly);

app.Run();
