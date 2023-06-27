using BurberBreakfast.Contracts.BurberBreakfast;
using BurberBreakfast.Models;
using BurberBreakfast.Services.Breakfasts;
using Microsoft.AspNetCore.Mvc;
namespace BurberBreakfast.Controllers;

[ApiController]
[Route("/breakfasts")]
public class BreakfastConstroller:ControllerBase
{
    private readonly IBreakfastService _breakfastService;

    public BreakfastConstroller(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }

    [HttpGet()]
    public IActionResult GetBreakfasts()
    {
        var breakfasts = _breakfastService.ReturnAllBreakfasts();
        return Ok(breakfasts);
    }

    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.Now,
            request.Savory,
            request.Sweet
        );

       _breakfastService.CreateBreakfast(breakfast);

        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name,
            breakfast.Description,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModiDateTime,
            breakfast.Savory,
            breakfast.Sweet
        );

        return CreatedAtAction(actionName: nameof(GetBreakfast), routeValues: new{id = breakfast.Id}, value: response);
    }
// breakfasts/{id}
[Route("{id:guid}")]
    [HttpGet]
    public IActionResult GetBreakfast(Guid id)
    {
        var breakfast = _breakfastService.GetBreakfast(id);


        return Ok(breakfast);
    }

    [Route("{id:guid}")]
    [HttpPut]
    public IActionResult UpsertBreakfast( Guid id,UppsertBreakfastRequest request)
    {
        var breakfast = new Breakfast(
            id,
            request.Name,
            request.Description,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.Now,
            request.Savory,
            request.Sweet
        );

        _breakfastService.UpdateBreakfast(breakfast);


        return Ok(breakfast);
    }

    [HttpDelete("(id:guid)")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        _breakfastService.DeleteBreakfast(id);

        return NoContent();
    }
}