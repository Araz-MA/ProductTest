﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Products.Models
{
    public class UpdateProductDto : CreateProductDto
    {
        public int Id { get; set; }        
    }
}
