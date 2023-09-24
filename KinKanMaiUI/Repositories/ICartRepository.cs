﻿namespace KinKanMaiUI.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int menuId, int qty);
        Task<int> RemoveItem(int menuId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task<bool> DoCheckout(string txt = "");

    }
}