using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Core.Application.Features.Categories.Commands.CreateCategories;
using RealEstateApp.Core.Application.Features.TypeOfProperties.Commands.CreateTypeOfProperties;
using RealEstateApp.Core.Application.ViewModels.Categories;
using Swashbuckle.AspNetCore.Annotations;

namespace RealEstateApp.Presentation.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Mantenimiento de tipo de propiedades")]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoriesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [SwaggerOperation(
                Summary = "Creacion de tipo de propiedad",
                Description = "Recibe los parametros necesarios para un nuevo tipo de propiedad."
              )]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        
        public async Task<IActionResult> Create([FromBody] SaveCategoriesViewModel createCategoryDto)
        {
            if (createCategoryDto == null)
            {
                return BadRequest("Category data is null.");
            }

            try
            {
                var command = _mapper.Map<CreateCategoriesCommand>(createCategoryDto);
                await _mediator.Send(command);
                return NoContent();
            }
            catch (Exception ex)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
    


