﻿
namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Policy;

    public partial class request
    {
        [Key]
        public string bookreq { get; set; }
        public int? amountreq { get; set; }
        public string message { get; set; }


    }
}
