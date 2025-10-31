namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IWishlistService
    {
        Task<bool> IsInWishlistAsync(string userId, long courseId);
        Task<bool> ToggleWishlistItemAsync(string userId, long courseId);
    }
}