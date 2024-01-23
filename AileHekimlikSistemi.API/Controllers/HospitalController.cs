using AileHekimlikSistemi.Core.DTOs;
using AileHekimlikSistemi.Core.Models;
using AileHekimlikSistemi.Core.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AileHekimlikSistemi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IHospitalService _hospitalService;
        public HospitalController(IMapper mapper, IHospitalService hospitalService)
        {
            _mapper = mapper;
            _hospitalService = hospitalService;
        }
        
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var hospitals = await _hospitalService.GetAllAsync();
            var hospitalsDto = _mapper.Map<List<HospitalDto>>(hospitals.ToList());
            return CreateActionResult(GlobalResultDto<List<HospitalDto>>.Success(200, hospitalsDto));
        }

        [HttpGet("{id}")]
        
        public async Task<IActionResult> GetById(int id)
        {
            var hospital = await _hospitalService.GetById(id);
            var hospitalDto = _mapper.Map<HospitalDto>(hospital);
            return CreateActionResult(GlobalResultDto<HospitalDto>.Success(200, hospitalDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(HospitalDto hospitalDto)
        {
            //var hospital1 = await _hospitalService.AddAsync(hospital);
            //return Ok(hospital1);
            var hospital = await _hospitalService.AddAsync(_mapper.Map<Hospital>(hospitalDto));
            var hospitalDtos = _mapper.Map<HospitalDto>(hospital);
            
            return CreateActionResult(GlobalResultDto<HospitalDto>.Success(201, hospitalDtos));
        }
      

        [HttpPut]
        public async Task<IActionResult> Update(HospitalDto hospitalDto)
        {
            await _hospitalService.UpdateAsync(_mapper.Map<Hospital>(hospitalDto));
            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var hospital = await _hospitalService.GetById(id);
            await _hospitalService.RemoveAsync(hospital);

            return CreateActionResult(GlobalResultDto<NoContentDto>.Success(204));
        }
    }
}
