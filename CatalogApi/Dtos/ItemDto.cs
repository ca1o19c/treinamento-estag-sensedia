using System;

namespace CatalogApi.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; set; }

        public string Name { get; init; }

        public string Description { get; init; }

        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }

    }


}

