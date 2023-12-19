using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV_Project_Group2.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace CV_Project_Group2.Controllers
{
    public class MessageController : Controller
    {

        private readonly CvDbContext _dbContext;    

        public MessageController(CvDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Inbox()
        {
            var userID = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var userMessages = _dbContext.Messages.Where(m => m.RecieverId == userID).ToList();
            return View("Inbox");
        }

       public async Task<IActionResult> SendMessage(string content)
        {
            var senderID = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var message = new Message
            {
                Content = content,
                // User_ID = senderID,
                SentTime = DateTime.UtcNow,

            };

            _dbContext.Messages.Add(message);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}
