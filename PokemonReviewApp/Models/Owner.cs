﻿namespace PokemonReviewApp.Models
{
    public class Owner
    {
        int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }

        public Country Country { get; set; }
    }
}
