using System;
using Microsoft.AspNetCore.Components;

namespace vsCodePersonelBlazorApp.BaseComponent
{
    public class dateTimeBaseComponent : ComponentBase
    {
        public DateTime dateTime { get; set; }

        public string GetDateTime()
        {
            dateTime = DateTime.Now;
            return dateTime.ToString("U");
        }
    } 
    
}

