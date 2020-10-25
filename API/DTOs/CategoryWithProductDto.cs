using System.Collections.Generic;

namespace API.DTOs
{
    public class CategoryWithProductDto:CategoryDto
    {
        public IEnumerable<ProductDto> products { get; set; }

    }
}