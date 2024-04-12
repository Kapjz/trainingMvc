﻿namespace My_Project
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Product>> GetProducts(string sTerm = "", int genreId = 0);
        Task<IEnumerable<Genre>> Genres();
    }
}