using System.Net.Mail;
using System.Net;

Console.Write("E-mail: ");
string toEmail = Console.ReadLine();

Console.Write("E-mail Baslıgı: ");
string subject = Console.ReadLine();

Console.Write("E-mail Bodysi: ");
string body = Console.ReadLine();


string smtpServer = "smtp.mailserver.com"; 
int smtpPort = 587; 
string smtpUsername = "samedyolchuyev"; 
string smtpPassword = "samed2008+"; 

try
{
    MailMessage mail = new MailMessage();
    mail.From = new MailAddress(smtpUsername);
    mail.To.Add(toEmail);
    mail.Subject = subject;
    mail.Body = body;

    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
    smtpClient.EnableSsl = true; 

    smtpClient.Send(mail);

    Console.WriteLine("E-mail gonderildi.");
}
catch (Exception ex)
{
    Console.WriteLine("E-mail gonderilen zaman xeta bas verdi: " + ex.Message);
}
