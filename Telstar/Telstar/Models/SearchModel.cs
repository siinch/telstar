using Microsoft.AspNetCore.Mvc;

namespace Telstar.Models;

public class SearchModel
{
    public String OriginCity { set; get; }
    public String DestinationCity { set; get; }
    public string Weight { set; get; }
    public string Width { set; get; }
    public string Height { set; get; }
    public string Length { set; get; }
    public Boolean Recommended { get; set; }
    public bool LiveAnimals { get; set; }
    public bool CautiousParcels { get; set; }
    public bool RefrigeratedGoods { get; set; }

    [HttpPost]
    public IActionResult CalculateRoute()
    {
        return null;
    }
    
    
}