﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    
        public class chucvu
        {
            public Guid Id { get; set; }
            public string Ma { get; set; }
            public string Ten { get; set; }

            public ICollection<NhanVien> NhanVien { get; set; }
        }
    
}
