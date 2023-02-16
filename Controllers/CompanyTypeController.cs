using AutoMapper;
using HR_API.Models;
using HR_API.Models.Dto.CompanyProfileDto;
using HR_API.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTypeController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ICompanyTypeRepository _repository;
        protected APIResponse _response;
        public CompanyTypeController(IMapper mapper, ICompanyTypeRepository repository, ILogger<CompanyType> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
            this._response = new();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetCompanyTypes()
        {
            try
            {
                var companyTypeList = await _repository.GetAllAsync();
                _response.Result = _mapper.Map<List<CompanyTypeDTO>>(companyTypeList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetCompanyType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetCompanyType(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var company = await _repository.GetAsync();
                if (company == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<CompanyTypeDTO>(company);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateCompany([FromBody] CompanyTypeCreateDTO createDTO)
        {
            try
            {
                var company = await _repository.GetAsync(x => x.CompanyName.ToLower() == createDTO.CompanyName.ToLower());
                if (company != null)
                {
                    ModelState.AddModelError("CustomError", "Company Type Already Exist");
                    return BadRequest(ModelState);
                }

                var model = _mapper.Map<CompanyType>(createDTO);

                await _repository.CreateAsync(model);
                _response.Result = _mapper.Map<CompanyTypeDTO>(company);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetCompanyType", new { id = model.CompanyTypeId }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeleteCompanyType")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteCompanyType(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var company = await _repository.GetAsync(x => x.CompanyTypeId == id);
                if (company == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                await _repository.RemoveAsync(company);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateCompany(int id, [FromBody] CompanyTypeUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.CompanyTypeId)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var model = _mapper.Map<CompanyType>(updateDTO);
                await _repository.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

    }
}
