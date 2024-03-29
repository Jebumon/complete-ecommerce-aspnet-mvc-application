﻿using JBU_Cinemas.Data.Base;
using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data.Services
{
    public interface IMovieService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
