﻿namespace SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType
{
    public class MessageTypeListVM 
    {
        public int Id {  get; set; }
        public string Type { get; set; } = string.Empty;
        public string EnglishType { get; set; } = string.Empty;
        public string ArabicType { get; set; } = string.Empty;
        public List<MessageTypeRoleDto> RoleName { get; set; } = new List<MessageTypeRoleDto>();
    }
}
