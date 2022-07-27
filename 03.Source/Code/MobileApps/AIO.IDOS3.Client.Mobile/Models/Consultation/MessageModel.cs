using System;
namespace AIO.IDOS3.Client.Mobile.Models
{
    public class MessageModel
    {
        public string User { get; set; }
        public string Message { get; set; }
        public bool IsOwnMessage { get; set; }
        public bool IsSystemMessage { get; set; }
    }
}