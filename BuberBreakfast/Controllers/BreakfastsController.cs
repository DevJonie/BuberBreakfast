using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts;
using BuberBreakfast.Services;
using BuberBreakfast.Extensions;

namespace BuberBreakfast.Controllers;

public class BreakfastsController : ApiController
{
    private readonly IBreakfastService _breakfastService;

    public BreakfastsController(
        IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }

    [HttpGet]
    public IActionResult GetBreakfast()
    {
        var breakfasts = _breakfastService.GetBreakfasts();
        return Ok(breakfasts.ToGetBreakfastResponse());
    }

    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        var breakfast = request.ToBreakfast();  

        var createBreakfastResult = _breakfastService.CreateBreakfast(breakfast);

        if (createBreakfastResult.IsError)
        {
            return Problem(createBreakfastResult.Errors);
        }

        return CreatedAtAction(
            nameof(GetBreakfast),
            new { id = breakfast.Id },
            breakfast.ToCreateBreakfastResponse());
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        var breakfastResult = _breakfastService.GetBreakfast(id);

        return breakfastResult.Match(
            breakfast => Ok(breakfast.ToGetBreakfastResponse()),
            errors => Problem(errors));
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateBreakfast(UpdateBreakfastRequest request, Guid id)
    {
        var breakfast = request.ToUpdateBreakfastResponse(id);

        var updateBreakfastResult = _breakfastService.UpdateBreakfast(breakfast);

        if(updateBreakfastResult.IsError)
        {
            return Problem(updateBreakfastResult.Errors);
        }

        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        var deleteBreakfastResult  = _breakfastService.DeleteBreakfast(id);

        return deleteBreakfastResult.Match(
            _ => NoContent(),
            errors => Problem(errors));
    }
}

