using Microsoft.AspNetCore.Mvc;

namespace Telstar.Models;

public class SearchModel
{
    public String OriginCity { set; get; }
    public String DestinationCity { set; get; }
    public double Weight { set; get; }
    public double Width { set; get; }
    public double Height { set; get; }
    public double Length { set; get; }
    
    [HttpPost]
    public IActionResult CalculateRoute()
    {
        return null;
    }
    
    
}