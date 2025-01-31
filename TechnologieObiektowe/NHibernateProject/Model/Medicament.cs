﻿namespace NHibernateProject.Model
{
    public class Medicament
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Recipe> Recipes { get; set; }
    }
}
