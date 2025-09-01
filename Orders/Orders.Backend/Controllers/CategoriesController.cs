using Microsoft.AspNetCore.Mvc;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountegoriesController : GenericController<Category>
{
    public CountegoriesController(IGenericUnitOfWork<Category> unitOfWork) : base(unitOfWork)
    {
    }
}