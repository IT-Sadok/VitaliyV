﻿using BusinessLogic.Model.GenreModel;
using BusinessLogic.Model.MovieModel;
using DataAccounts.Entitys.MovieEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IGenreService
    {
        Task CreateGenre(CreateGenreModel createModel);
        Task DeleteGenre(DeleteGenreModel deleteModel);
        Task<List<GenreDto>> GetGenre();
    }
}