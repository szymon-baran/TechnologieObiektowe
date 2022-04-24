﻿namespace EntityFrameworkProject
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
