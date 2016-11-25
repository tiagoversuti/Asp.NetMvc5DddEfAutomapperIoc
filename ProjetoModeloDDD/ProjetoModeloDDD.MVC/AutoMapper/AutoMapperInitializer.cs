using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(typeof(AutoMapperInitializer));
                cfg.CreateMap<Cliente, ClienteViewModel>();
                cfg.CreateMap<ClienteViewModel, Cliente>();
                cfg.CreateMap<Produto, ProdutoViewModel>();
                cfg.CreateMap<ProdutoViewModel, Produto>();
            });
        }
    }
}