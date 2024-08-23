using HelloASPNETcoreDeveloper.Generic.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPNETcoreDeveloper.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route(template:"[controller]")]
public class WelcomeController : ControllerBase //Framework .NET y en Microsoft el API ASP.CORE; Esta clase es descendiente de ControllerBase
{
    [HttpGet]
    public string welcome()
    {
        return WelcomeBuilder.Build(name: null);
    }

    [HttpGet(template: "{name}")]
    public string welcome(string name)
    {
        return WelcomeBuilder.Build(name);
    }
}
