using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSender.Models.Domains
{
    public class Attachment
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public int EmailMessageId { get; set; }
        public EmailMessage EmailMessage { get; set; }
    }

}