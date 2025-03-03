﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Domain.Models;

namespace MvcMovie.Models.ViewModel
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
