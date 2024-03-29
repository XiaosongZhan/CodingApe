﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using Vidly.Dtos;
using AutoMapper;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomersController() {
            _context = new ApplicationDbContext();
        }
        //Get /API/customers
        public IEnumerable<CustomerDto> GetCustomers() {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }

        //GET /API/customer/1
        public CustomerDto GetCustomer(int id) {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound); 
            }
            return Mapper.Map<Customer, CustomerDto>(customer);
        }


        //POST /API/customers
        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid) {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customerDto;
        }

        //put /API/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto) {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if(customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map(customerDto, customerInDb);
            
            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteCustomer(int id) {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }


    }
}
