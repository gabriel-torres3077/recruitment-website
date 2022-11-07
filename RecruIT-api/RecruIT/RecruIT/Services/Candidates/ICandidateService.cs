namespace RecruIT.Services.Candidates;
using RecruIT.Models;
using RecruIT.ServiceErrors;
using ErrorOr;

public interface ICandidateService
{
    void CreateCandidate(Candidate candidate);
    void DeleteCandidate(Guid Id);
    ErrorOr<Candidate> GetCandidate(Guid Id);
    void UpsertCandidate(Candidate candidate);
    Dictionary<Guid, Candidate> GetAllCandidates();
}    
