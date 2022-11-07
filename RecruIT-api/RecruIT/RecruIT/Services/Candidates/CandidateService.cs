using RecruIT.Models;
using RecruIT.ServiceErrors;
using ErrorOr;

namespace RecruIT.Services.Candidates;

public class CandidateService : ICandidateService
{
    private static readonly Dictionary<Guid, Candidate> _candidate = new();

    public void CreateCandidate(Candidate candidate)
    {
        _candidate.Add(candidate.Id, candidate);
    }
    public void DeleteCandidate(Guid id)
    {
        _candidate.Remove(id);
    }
    public ErrorOr<Candidate> GetCandidate(Guid id)
    {
        if (_candidate.TryGetValue(id, out var candidate))
        {
            return candidate;
        }
        return Errors.Candidate.NotFound;
    }
    public Dictionary<Guid, Candidate> GetAllCandidates()
    {
        return _candidate;
    }
    public void UpsertCandidate(Candidate candidate)
    {
        _candidate[candidate.Id] = candidate;
    }
}