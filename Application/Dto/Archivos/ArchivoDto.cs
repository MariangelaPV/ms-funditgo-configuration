﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Archivos
{
    public class ArchivoDto
    {
        public Guid FileId { get; set; }
        public byte[] Content { get; set; }
        public string MimeType { get; set; }
    }
}
