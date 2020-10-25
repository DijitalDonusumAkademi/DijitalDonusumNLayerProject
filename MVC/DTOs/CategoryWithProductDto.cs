using System.Collections.Generic;

namespace MVC.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public IEnumerable<ProductDto> products { get; set; }
    }
}