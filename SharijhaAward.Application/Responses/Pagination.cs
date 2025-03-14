﻿using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Responses
{
    public class Pagination
    {
        public int current_page { get; set; }
        public int last_page { get; set; }                
        public int total_row { get; set; }                 
        public int per_page { get; set; }                
        public Pagination(int page, int perPage, int count)
        {
            current_page = page;
            last_page = (int)Math.Ceiling((decimal)count / perPage);
            total_row = count;
            per_page = perPage;
        }
    }
}
