//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food4FunEngine.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipe
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<Ingredient>();
        }
    
        public System.Guid Id { get; private set; }
        public string Name { get; set; }
        public string WorkDiscription { get; set; }
        public Nullable<RecipeOriginCountry> OriginCountry { get; set; }
    
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
