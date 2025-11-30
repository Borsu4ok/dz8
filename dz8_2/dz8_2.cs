using System;

interface ILogger
{
    void Log(string msg);
}

class ConsoleLogger : ILogger
{
    public void Log(string msg) => Console.WriteLine(msg);
}

class Email
{
    public string Theme { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}

class EmailSender
{
    private readonly ILogger logger;

    public EmailSender(ILogger logger)
    {
        this.logger = logger;
    }

    public void Send(Email email)
    {
        logger.Log($"Email from '{email.From}' to '{email.To}' sent");
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Hi" };

        EmailSender sender = new EmailSender(new ConsoleLogger());
        sender.Send(e1);
    }
}
