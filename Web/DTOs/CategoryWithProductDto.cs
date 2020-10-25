using System.Collections.Generic;


namespace Web.DTOs
{
    public class CategoryWithProductDto : CategoryDto
    {
        public IEnumerable<ProductDto> products { get; set; }
    }
}