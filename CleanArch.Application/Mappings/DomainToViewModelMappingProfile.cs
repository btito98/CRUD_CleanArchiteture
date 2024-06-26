﻿using AutoMapper;
using Clinica.Application.ViewModels;
using Clinica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Medico, MedicoViewModel>();
            CreateMap<Paciente, PacienteViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
