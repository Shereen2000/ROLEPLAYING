using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RolePlaying.Models;

namespace RolePlaying.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        //private static Character Knight = new Character();
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name="Same"}
        };

        [HttpGet("GetAll")]
        // public ActionResult<Character> Get(){
        //     return Ok(Knight);
        //     //return NotFound(Knight);
        //     //return BadRequest(Knight);
        // }

         public ActionResult<List<Character>> Get(){
            return Ok(characters);
            //return NotFound(Knight);
            //return BadRequest(Knight);
        }


        [HttpGet]
        public ActionResult<Character> GetSingle(){
            return Ok(characters[0]);
            //return NotFound(Knight);
            //return BadRequest(Knight);
        }


    }
}