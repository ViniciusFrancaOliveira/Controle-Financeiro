using ControleFinanceiro.Models;
using ControleFinanceiro.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ControleFinanceiro.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class RevenueController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RevenueController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; 
        }

        [HttpGet("Revenues")]
        public async Task<IActionResult> GetAllRevenues()
        {
            try
            {
                List<Revenue> revenues = await _unitOfWork.RevenueRepository.GetAll().ToListAsync(); 
                return Ok(revenues);
            }
            catch (Exception)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRevenueById(int id)
        {
            try
            {
                Revenue revenue = await _unitOfWork.RevenueRepository.GetById(revenue => revenue.Id == id);

                if (revenue != null)
                {
                    return Ok(revenue);
                }

                return NotFound();
            }
            catch (Exception)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddRevenue(Revenue revenue)
        {
            if (revenue == null) return BadRequest();

            try
            {
                _unitOfWork.RevenueRepository.Insert(revenue);
                await _unitOfWork.SaveChangesAsync();
                return Ok();
            }
            catch (Exception) 
            { 
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}
