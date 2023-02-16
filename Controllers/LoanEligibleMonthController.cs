using AutoMapper;
using HR_API.Models.Dto.CompanyProfileDto;
using HR_API.Models;
using HR_API.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanEligibleMonthController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ILoanEligibleMonthRepository _repository;
        protected APIResponse _response;
        public LoanEligibleMonthController(IMapper mapper, ILoanEligibleMonthRepository repository, ILogger<LoanEligibleMonth> logger)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
            this._response = new();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetLoanEligibleMonths()
        {
            try
            {
                var LoanEligibleMonthList = await _repository.GetAllAsync();
                _response.Result = _mapper.Map<List<LoanEligibleMonthDTO>>(LoanEligibleMonthList);
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

        [HttpGet("{id:int}", Name = "GetLoanEligibleMonth")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetLoanEligibleMonth(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var LoanEligibleMonth = await _repository.GetAsync();
                if (LoanEligibleMonth == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<LoanEligibleMonthDTO>(LoanEligibleMonth);
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
        public async Task<ActionResult<APIResponse>> CreateSalary([FromBody] LoanEligibleMonthCreateDTO createDTO)
        {
            try
            {
                var LoanEligibleMonth = await _repository.GetAsync(x => x.LoanEligibleMonths.ToLower() == createDTO.LoanEligibleMonths.ToLower());
                if (LoanEligibleMonth != null)
                {
                    ModelState.AddModelError("CustomError", "Salary Method Already Exist");
                    return BadRequest(ModelState);
                }

                var model = _mapper.Map<LoanEligibleMonth>(createDTO);

                await _repository.CreateAsync(model);
                _response.Result = _mapper.Map<LoanEligibleMonthDTO>(LoanEligibleMonth);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetLoanEligibleMonth", new { id = model.LoanEligibleMonthId }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{id:int}", Name = "DeleteLoanEligibleMonth")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> DeleteLoanEligibleMonth(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var LoanEligibleMonth = await _repository.GetAsync(x => x.LoanEligibleMonthId == id);
                if (LoanEligibleMonth == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                await _repository.RemoveAsync(LoanEligibleMonth);
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
        public async Task<ActionResult<APIResponse>> UpdateLoanEligibleMonth(int id, [FromBody] LoanEligibleMonthUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.LoanEligibleMonthId)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var model = _mapper.Map<LoanEligibleMonth>(updateDTO);
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
