using RecruIT.Models;

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
    public Candidate GetCandidate(Guid id)
    {
        return _candidate[id];
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