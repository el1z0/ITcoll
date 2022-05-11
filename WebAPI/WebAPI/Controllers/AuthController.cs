using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AuthController : Controller
    {
        private readonly ITcollContext _context;

        public AuthController(ITcollContext context)
        {
            _context = context;
        }

        // GET: AuthController/GetUser/
        [HttpGet("login, password")]
        public async Task<ActionResult<User>> GetUser(string login, string password)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var getuser = _context.Users.Where(w=>w.Login == login && w.Password == GetHashString(password)).FirstOrDefault();

            if (getuser != null)
            {
                return Ok(getuser);
            }

            return getuser;
        }

        Guid GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            var CSP =
                new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
            return new Guid(hash);
        }
    }
}
