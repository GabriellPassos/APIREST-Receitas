﻿using ReceitasAPI.Data;
using ReceitasAPI.Models;

namespace ReceitasAPI.Services
{
    public class IngredientService
    {
        public RecipeContext _context;
        public IngredientService(RecipeContext receitasContext)
        {
            _context = receitasContext;
        }
        public Ingredient Create(string name) 
        {
            Ingredient ingrediente = _context.Ingredients.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            if (ingrediente == null)
            {
                ingrediente = new Ingredient(name);
                _context.Ingredients.Add(ingrediente);
                _context.SaveChanges();
                return ingrediente;
            }
            return ingrediente;
        }
        public Ingredient Search(int ingredientId) { return _context.Ingredients.FirstOrDefault(x => x.Id == ingredientId); }
    }
}
