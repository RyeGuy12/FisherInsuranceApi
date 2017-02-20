using Microsoft.AspNetCore.Mvc; 
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/claims/quotes")]
public class ClaimsController : Controller{

    private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
        db = repo;
    }
        [HttpGet]
    public IActionResult GetClaims()
    {
        return Ok(db.RetrieveAllClaims);
    }  
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(db.RetrieveClaim(id));
    }    
    [HttpPost]        
    public IActionResult Post([FromBody] Claim claim)
    {           
         return Ok(db.CreateClaim(claim));
    }     
    
    [HttpPut("{id}")]        
    public IActionResult Put([FromBody] Claim claim)        
    {            
        return Ok(db.UpdateClaim(claim));        
    }
    [HttpDelete("{id}")]        
    public IActionResult Delete([FromBody] int id)        
    {   
        db.DeleteClaim(id);         
        return Ok();        
    }
}