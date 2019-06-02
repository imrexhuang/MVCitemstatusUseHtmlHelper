using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCitemstatus.Models
{
    public class ItemViewModels
    {
        [DisplayName("編號")]
        public int Id { get; set; }

        [DisplayName("狀態")]
        public String Status { get; set; }
    }
}