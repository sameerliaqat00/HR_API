using AutoMapper;
using HR_API.Models.Dto.CompanyProfileDto;
using HR_API.Models;
using HR_API.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace HR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegularizedPeriodController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IRegularizedPeriodRepository _repository;
        protected APIResponse _response;
        public RegularizedPeriodController(IMapper mapper, IRegularizedPeriodRepository repository, ILogger<RegularizedPeriod> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
            this._response = new();
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Default30")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetRegularizedPeriods([FromQuery] string? search, int pageSize = 0, int pageNumber = 1)
        {
            try
            {
                IEnumerable<RegularizedPeriod> regularizedPeriodList;
                regularizedPeriodList = await _repository.GetAllAsync(pageSize: pageSize,
                        pageNumber: pageNumber);

                if (!string.IsNullOrEmpty(search))
                {
                    regularizedPeriodList = regularizedPeriodList.Where(u => u.RegularizedPeriods.ToLower().Contains(search));
                }
                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };

                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));
                _response.Result = _mapper.Map<List<CityDTO>>(regularizedPeriodList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
           
            return _response;
        }

        [HttpGet("{id:int}", Name = "GetRegularizedPeriod")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetRegularizedPeriod(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var RegularizedPeriod = await _repository.GetAsync();
                if (RegularizedPeriod == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<RegularizedPeriodDTO>(RegularizedPeriod);
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
        public async Task<ActionResult<APIResponse>> CreateSalary([FromBody] RegularizedPeriodCreateDTO createDTO)
        {
            try
            {
                var RegularizedPeriod = await _repository.GetAsync(x => x.RegularizedPeriods.ToLower() == createDTO.RegularizedPeriods.ToLower());
                if (RegularizedPeriod != null)
                {
                    ModelState.AddModelError("CustomError", "Salary Method Already Exist");
                    return BadRequest(ModelState);
                }

                var model = _mapper.Map<RegularizedPeriod>(createDTO);

                await _repository.CreateAsync(model);
                _response.Result = _mapper.Map<RegularizedPeriodDTO>(RegularizedPeriod);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetRegularizedPeriod", new { id = model.RegularizedPeriodId }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeleteRegularizedPeriod")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteRegularizedPeriod(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var RegularizedPeriod = await _repository.GetAsync(x => x.RegularizedPeriodId == id);
                if (RegularizedPeriod == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                await _repository.RemoveAsync(RegularizedPeriod);
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

        [HttpPut("{id:int}", Name = "UpdateRegularizedPeriod")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateRegularizedPeriod(int id, [FromBody] RegularizedPeriodUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.RegularizedPeriodId)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var model = _mapper.Map<RegularizedPeriod>(updateDTO);
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
