namespace RecruIT.Contracts.Candidates;

public record CreateCandidateRequest(
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
