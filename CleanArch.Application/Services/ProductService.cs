﻿using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public void Add(ProductViewModel product)
        {
            var mapProduct = _mapper.Map<Product>(product);   
            _productRepository.Add(mapProduct);
        }

        public async Task<ProductViewModel> GetById(int? id)
        {
            var result = await _productRepository.GetById(id);
            return _mapper.Map<ProductViewModel>(result);
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            var result = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);
        }

        public void Remove(int? id)
        {
            var product =  _productRepository.GetById(id).Result;
            _productRepository.Remove(product);
        }

        public async void Update(ProductViewModel product)
        {
            var mapProduct = _mapper.Map<Product>(product);
            _productRepository.Update(mapProduct);
        }
    }
}
