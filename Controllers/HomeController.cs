using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[] 
        { new StudentInfoModel { StudentName = "Januar Domingo", StudAge = "18", Contact = "09662857208", Address = "Payatas", YearandSection= "BAIT-2D", Campus = "Batasan"},
         new StudentInfoModel { StudentName = "James Reid", StudAge = "20", Contact = "093454377758", Address = "Commonwealth", YearandSection= "SBIT-3L", Campus = "San Bartolome" }, 
         new StudentInfoModel { StudentName = "Enrique Gil", StudAge = "28", Contact = "09346347573573", Address = "Fairview", YearandSection= "SFIT-2A", Campus = "San Francisco" },
          new StudentInfoModel { StudentName = "Daniel Padilla", StudAge = "22", Contact = "094353453453", Address = "Holy Spirit", YearandSection= "SBIT-4F", Campus = "San Francisco" } };

        return View(studentInfoArray);
        
    }
}
