using AutoMapper;
using HR_API.Data;
using HR_API.Models;
using HR_API.Models.Dto;
using HR_API.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyProfileController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ICompanyProfileRepository _repository;
        public CompanyProfileController(IMapper mapper, ICompanyProfileRepository repository, ILogger<CompanyProfile> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyProfileDTO>>> GetCompanies()
        {
            var companyList = await _repository.GetAllAsync();
            return Ok(_mapper.Map<List<CompanyProfileDTO>>(companyList));
        }

        [HttpGet("{id:int}", Name = "GetCompany")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CompanyProfileDTO>> GetCompany(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var company = await _repository.GetAsync();
            if (company == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CompanyProfileDTO>(company));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CompanyProfileDTO>> CreateCompany([FromBody] CompanyProfileCreateDTO createDTO)
        {
            var company = await _repository.GetAsync(x => x.CompanyName.ToLower() == createDTO.CompanyName.ToLower());
            if (company != null)
            {
                ModelState.AddModelError("CustomError", "Company Already Exists");
                return BadRequest(ModelState);
            }
            if (company == null)
            {
                return BadRequest();
            }
            var model = _mapper.Map<CompanyProfile>(createDTO);
            await _repository.CreateAsync(model);
            return CreatedAtRoute("GetCompany", new { id = model.CompanyId }, model);
        }

        [HttpDelete("{id:int}", Name = "DeleteCompany")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteCompany(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var company = await _repository.GetAsync(x => x.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }
            await _repository.RemoveAsync(company);
            return NoContent();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CompanyProfileDTO>> UpdateCompany(int id, [FromBody] CompanyProfileUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.CompanyId)
            {
                return BadRequest();
            }
            var model = _mapper.Map<CompanyProfile>(updateDTO);
            await _repository.UpdateAsync(model);
            return NoContent();
        }

    }
}
