Este projeto simula o envio de e-mails através do HangFire.

## Stack
- ASP.NET Core;
- HangFire.

## Como Funciona?
Ele simula o envio mensal de emails. Não é um envio verdadeiro, apenas simula.
O intuito é mostrar como o Hangfire funciona.

Nesta parte do código é possível alterar para envios mensais, diarios e etc:

`RecurringJob.AddOrUpdate<IEmailService>(
    x => x.SendEmailAsync("admin@site.com", "Relatório diário", "Conteúdo..."),
    Cron.Monthly);`

Nesta parte indica como acessar o Dashboard:

`app.UseHangfireDashboard("/hangfire");`

## Referências
Este projeto foi desenvolvido com base em um artigo técnico.
Site: https://blog.balta.io/agendando-emails-no-dotnet-com-hangfire/
