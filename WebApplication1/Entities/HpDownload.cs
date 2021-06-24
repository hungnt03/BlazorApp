using System;
using System.Collections.Generic;

#nullable disable

namespace Blazor.Server.Entities
{
    public partial class HpDownload
    {
        public int FileId { get; set; }
        public string FilePassword { get; set; }
        public string FileName { get; set; }
        public double? FileSize { get; set; }
        public string FileComment { get; set; }
        public string Mail { get; set; }
        public string LogonUser { get; set; }
        public short? LogonCount { get; set; }
        public short? LogonMax { get; set; }
        public short? DownloadCount { get; set; }
        public short? DownloadMax { get; set; }
        public DateTime? DownloadDate { get; set; }
        public DateTime? TourokuDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Expired { get; set; }
    }
}
