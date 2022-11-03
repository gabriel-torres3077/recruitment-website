namespace RecruIT.Services.Candidates;
using RecruIT.Models;

public interface ICandidateService
{
    void CreateCandidate(Candidate candidate);
    void DeleteCandidate(Guid Id);
    Candidate GetCandidate(Guid Id);
    void UpsertCandidate(Candidate candidate);
    Dictionary<Guid, Candidate> GetAllCandidates();
}    
