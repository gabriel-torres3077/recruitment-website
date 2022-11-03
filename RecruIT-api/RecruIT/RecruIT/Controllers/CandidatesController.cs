using RecruIT.Contracts.Candidates;
using RecruIT.Models;
using Microsoft.AspNetCore.Mvc;
using RecruIT.Services.Candidates;


namespace RecruIT.Controllers;
[ApiController]
[Route("[controller]")]
public class CandidatesController: ControllerBase
{
    private readonly ICandidateService _candidateService;
    public CandidatesController(ICandidateService candidateService)
    {
        _candidateService = candidateService;
    }
    [HttpPost()]
    public IActionResult CreateCandidate(CreateCandidateRequest request)
    {
        var candidate = new Candidate(
            Guid.NewGuid(),
            request.Name,
            request.Cpf,
            request.Age,
            request.IsActive,
            request.Email,
            request.Bio,
            request.Skills,
            request.Links
            );
        //Save Candidate model on database
        _candidateService.CreateCandidate(candidate);

        var response = new CandidateResponse(
            candidate.Id,
            candidate.Name,
            candidate.Cpf,
            candidate.Age,
            candidate.IsActive,
            candidate.Email,
            candidate.Bio,
            candidate.Skills,
            candidate.Links
        );
        return CreatedAtAction(
            actionName: nameof(GetCandidate),
            routeValues: new { id = candidate.Id },
            value: response
        );
    }
    [HttpGet("all")]
    public IActionResult GetAllCandidates()
    {
        Dictionary<Guid, Candidate> candidates = _candidateService.GetAllCandidates();
        return Ok(candidates);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetCandidate(Guid id)
    {
        Candidate candidate = _candidateService.GetCandidate(id);

        var response = new CandidateResponse(
            candidate.Id,
            candidate.Name,
            candidate.Cpf,
            candidate.Age,
            candidate.IsActive,
            candidate.Email,
            candidate.Bio,
            candidate.Skills,
            candidate.Links
        );
        return Ok(response);
    }
    [HttpPut("{id:guid}")]
    public IActionResult UpsertCandidate(Guid id, UpsertCandidateRequest request)
    {
        var candidate = new Candidate(
            id,
            request.Name,
            request.Cpf,
            request.Age,
            request.IsActive,
            request.Email,
            request.Bio,
            request.Skills,
            request.Links
        );
        _candidateService.UpsertCandidate(candidate);

        return NoContent();
    }
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteCandidate(Guid id)
    {
        return NoContent();
    }
}