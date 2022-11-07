using RecruIT.Contracts.Candidates;
using RecruIT.Models;
using Microsoft.AspNetCore.Mvc;
using RecruIT.Services.Candidates;
using ErrorOr;
using RecruIT.ServiceErrors;

namespace RecruIT.Controllers;

public class CandidatesController: ApiController
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
        ErrorOr<Candidate> getCandidateResult = _candidateService.GetCandidate(id);

        return getCandidateResult.Match(
            candidate => Ok(MapCandidateResponse(candidate)),
            errors => Problem(errors));
    }
    private static CandidateResponse MapCandidateResponse(Candidate candidate)
    {
        return new CandidateResponse(
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