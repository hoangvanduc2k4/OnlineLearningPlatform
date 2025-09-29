using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Hubs;
using OnlineLearningPlatform.Models.Entities.UserPart;
using OnlineLearningPlatform.Services.Implementations;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Controllers
{
    //[Authorize(Roles = $"{nameof(RoleType.MENTOR)},{nameof(RoleType.MENTEE)}")]
    public class ChatController : Controller
    {
        private readonly IMessageService _messageService;
        //private readonly IUserService _userService;
        private readonly IHubContext<UserChatHub> _userChatHubContext;
        UserManager<User> _userManager;

        public ChatController(UserManager<User> userManager, IMessageService messageService, IHubContext<UserChatHub> userChatHubContext)
        {
            _userManager = userManager;
            _messageService = messageService;
            _userChatHubContext = userChatHubContext;
        }

        //private readonly IUserRoleService _userRoleService;
        //private readonly IHubContext<UserChatHub> _userChatHubContext;
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = await _userManager.GetUserIdAsync(user);
            
            if(userId == null) return RedirectToAction("Index", "Home");
            var chatPartners = await _messageService.GetChatPartnersAsync(userId);
            return View(chatPartners);
        }

        [HttpGet]
        public async Task<IActionResult> Chat(string partnerId)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var userId = await _userManager.GetUserIdAsync(currentUser);
            var partner = await _userManager.FindByIdAsync(partnerId);

            if (currentUser == null || partner == null)
            {
                return NotFound();
            }

            // Đánh dấu tin nhắn đã đọc
            await _messageService.MarkMessagesAsReadAsync(partnerId, userId);

            // Thông báo cho người gửi rằng tin nhắn đã được đọc thông qua SignalR
            await _userChatHubContext.Clients.Group(partnerId.ToString())
                .SendAsync("MessagesRead", userId);

            // Lấy lịch sử tin nhắn
            var messages = await _messageService.GetMessagesBetweenUsersAsync(userId, partnerId);

            ViewBag.CurrentUser = currentUser;
            ViewBag.Partner = partner;

            return View(messages);
        }


        [HttpGet]
        public async Task<IActionResult> ChatWithMentor(string mentorId)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            // Kiểm tra xem người dùng có phải là mentee không
            //var userRoles = await _userRoleService.GetRolesByUserIdAsync(userId);
            //bool isMentee = userRoles.Contains(Enums.RoleType.MENTEE);

            //if (!isMentee)
            //{
            //    return RedirectToAction("Index", "Home");
            //}

            return RedirectToAction("Chat", new { partnerId = mentorId });
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(string receiverId, string content)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var senderId = await _userManager.GetUserIdAsync(currentUser);

            var message = await _messageService.SendMessageAsync(senderId, receiverId, content);

            // Gửi tin nhắn qua SignalR
            await _userChatHubContext.Clients.Group(receiverId.ToString())
                .SendAsync("ReceiveMessage", message);

            return RedirectToAction("Chat", new { partnerId = receiverId });
        }
        [HttpGet]
        public async Task<IActionResult> GetUnreadCount()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var userId = await _userManager.GetUserIdAsync(currentUser);
            var chatPartners = await _messageService.GetChatPartnersAsync(userId);
            int unreadCount = chatPartners.Sum(cp => cp.UnreadCount);

            return Json(unreadCount);
        }
    }
}
