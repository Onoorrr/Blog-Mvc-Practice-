﻿using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Extensions
{
	public static class ServiceLayerExtension
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
		{
			var assembly = Assembly.GetExecutingAssembly();

			services.AddScoped<IArticleService, ArticleService>();

			services.AddAutoMapper(assembly);

			return services;
		}
	}
}
