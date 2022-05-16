using Api.Data;
using Api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SnippetsController : ControllerBase
{
    private readonly ILogger<SnippetsController> logger;
    private readonly ISnippetsRepository repository;

    public SnippetsController(ILogger<SnippetsController> logger, ISnippetsRepository repository)
    {
        this.logger = logger;
        this.repository = repository;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<SnippetDto>> Get()
    {
        return await repository.GetAll();
    }
}
