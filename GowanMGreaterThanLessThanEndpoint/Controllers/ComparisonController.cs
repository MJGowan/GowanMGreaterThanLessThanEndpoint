/*Madeline Gowan
10-25-2022
Greater Than or Less Than - Endpoint
In this assignment we enter two numbers into the url and it should say which of them is greater than or lesser than the other, in a way that is compatible with postman

Peer review: Andrew Nilsson - The inputs work well in postman. Good job making the string look like 2 lines.
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMGreaterThanLessThanEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ComparisonController : ControllerBase
{
    [HttpGet]
    [Route("Compare/{number1}/{number2}")]

    public string Compare(int number1, int number2)
    {
        //https://localhost:xxxx/Comparison/Compare/x/x

        if (number1 > number2)
        {
            return $"{number1} is greater than {number2} \n {number2} is lesser than {number1}";
        }
        else if(number1 < number2){
            return $"{number1} is lesser than {number2} \n {number2} is greater than {number1}";
        }
        else
            return $"Those numbers are equal.";
    }
}
