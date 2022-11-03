namespace RecruIT.Contracts.Candidates;

public record CandidateResponse(
    Guid Id,
    string Name,
    string Cpf,
    int Age,
    bool IsActive,
    string Email,
    string Bio,
    Object Skills,
    List<string> Links
);
