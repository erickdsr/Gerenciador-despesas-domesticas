using HouseholdExpenseManager.Api.DTOs.Person;
using HouseholdExpenseManager.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HouseholdExpenseManager.Api.Controllers;

[ApiController]
[Route("api/people")]
public class PeopleController(IPersonService personService) : ControllerBase
{
    // Returns all registered people.
    [HttpGet]
    public async Task<ActionResult<List<PersonResponse>>> GetAllAsync()
    {
        var people = await personService.GetAllAsync();

        return Ok(people);
    }

    // Creates a new person.
    [HttpPost]
    public async Task<ActionResult<PersonResponse>> CreateAsync(CreatePersonRequest request)
    {
        var person = await personService.CreateAsync(request);

        return CreatedAtAction(nameof(GetAllAsync), new { id = person.Id }, person);
    }

    // Deletes a person by id.
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await personService.DeleteAsync(id);

        return NoContent();
    }
}
