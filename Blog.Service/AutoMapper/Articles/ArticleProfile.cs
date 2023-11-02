﻿using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Articles
{
	public class ArticleProfile : Profile
	{
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap(); //Bu kod ile istersek ArticleDto istersek Article ile Article istersek ArticleDto ile mapleyebiliyir
        }
    }
}
