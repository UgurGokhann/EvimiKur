﻿using EvimiKur.Dtos;
using EvimiKur.Dtos.Interfaces;
using EvimiKur.Entities.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EvimiKur.Dtos
{
    public class ProductCreateDto : IDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public bool Status { get; set; }
        public bool ShowroomType { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public IFormFile UploadImage { get; set; }
        public int DealerId { get; set; }
        public DealerListDto Dealer { get; set; }
        public int CategoryId { get; set; }
        public CategoryListDto Category { get; set; }
       



    }
}
