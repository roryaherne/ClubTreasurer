﻿using System.Net.Mail;
using System.Threading.Tasks;

namespace ClubTreasurer.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message, Attachment attachment);
    }
}
