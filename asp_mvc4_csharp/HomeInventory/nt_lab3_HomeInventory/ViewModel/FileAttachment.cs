using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nt_lab3_HomeInventory.ViewModel
{
    public class FileAttachment
    {
        public int ItemId { get; set; }
        public HttpPostedFileBase File { get; set; }
        public string Message { get; set; }

    }
}