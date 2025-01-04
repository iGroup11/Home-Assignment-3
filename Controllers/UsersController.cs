using HW3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HW3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User user = new User();
            return user.read();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public int Post([FromBody] User user)
        {
            return user.insert();
        }
        [HttpPost("SearchUser")]
        public User searchUser([FromBody] User user)
        {
            return user.searchUser(); // This will return the UsersList
        }


        /*
        public User searchUser(string email,string password)
        {
            User user = new User();

            return user.searchUser(email,password); // This will return the UsersList
        }
        */
        [HttpPut("{id}")]
        public int Put(int id, [FromBody] User user)
        {
            return user.updateUserDetails(id);

        }
        /* [HttpPost("SearchUser")] ///QueryString for searching user
         public User searchUser(string email)
         {
             User user=new User();
             return user.searchUser(email);
         }
        */
        // PUT api/<UsersController>/5
        //          [HttpPut("{id}")]
        //    public void Put(int id, [FromBody] string value)
        //   {
        //  }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        ///new method to get logged user 
        ///
        [HttpGet("AddGametoUser")]
        public int UserGame(int userId, int gameId)
        {

            User user = new User();
            return user.AddGametoUser(userId, gameId);

        }
    }
}
