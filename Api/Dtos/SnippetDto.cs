namespace Api.Dto;

public record SnippetDto(int Id, string? Title, string? Description,
    string? FileUrl);