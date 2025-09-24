using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Repositories.Interfaces;

namespace OnlineLearningPlatform.Repositories.Implementations
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        public MessageRepository(OnlineLearningDBContext context) : base(context)
        {
        }

        public async Task<Message> AddMessageAsync(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return message;
        }

        public async Task<int> CountUnreadMessagesAsync(string senderId, string receiverId)
        {
            return await _context.Messages
                 .CountAsync(m => m.SenderId == senderId && m.ReceiverId == receiverId && !m.IsRead);
        }

        public async Task<IEnumerable<Message>> GetLatestMessagesForUserAsync(string userId)
        {
            // Lấy danh sách các người dùng đã tương tác (chat) với userId
            var chatPartners = await _context.Messages
                .Where(m => m.SenderId == userId || m.ReceiverId == userId)
                .Select(m => m.SenderId == userId ? m.ReceiverId : m.SenderId)
                .Distinct()
                .ToListAsync();

            // Danh sách tin nhắn mới nhất với mỗi người
            var latestMessages = new List<Message>();

            foreach (var partnerId in chatPartners)
            {
                // Lấy tin nhắn mới nhất giữa userId và partnerId
                var latestMessage = await _context.Messages
                    .Where(m => m.SenderId == userId && m.ReceiverId == partnerId ||
                               m.SenderId == partnerId && m.ReceiverId == userId)
                    .OrderByDescending(m => m.CreatedAt)
                    .Include(m => m.Sender)
                    .Include(m => m.Receiver)
                    .FirstOrDefaultAsync();

                if (latestMessage != null)
                {
                    latestMessages.Add(latestMessage);
                }
            }

            return latestMessages.OrderByDescending(m => m.CreatedAt);
        }

        public async Task<IEnumerable<Message>> GetMessagesBetweenUsersAsync(string senderId, string receiverId)
        {
            return await _context.Messages
                .Where(m => m.SenderId == senderId && m.ReceiverId == receiverId ||
                           m.SenderId == receiverId && m.ReceiverId == senderId)
                .OrderBy(m => m.CreatedAt)
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .ToListAsync();
        }

        public async Task MarkMessagesAsReadAsync(string senderId, string receiverId)
        {
            var unreadMessages = await _context.Messages
              .Where(m => m.SenderId == senderId && m.ReceiverId == receiverId && !m.IsRead)
              .ToListAsync();

            foreach (var message in unreadMessages)
            {
                message.IsRead = true;
            }

            await _context.SaveChangesAsync();
        }
    }
}
