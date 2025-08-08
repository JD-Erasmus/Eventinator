namespace Eventinator.ViewModels
{
    public sealed class DiscoverViewModel
    {
        public List<CategoryChip> PopularCategories { get; init; } = new()
        {
            new CategoryChip("Tech", "tech"),
            new CategoryChip("Music", "music"),
            new CategoryChip("Art", "art"),
            new CategoryChip("Business", "business")
        };
        public List<CityItem> TrendingCities { get; init; } = new()
        {
            new CityItem("Windhoek", "windhoek", 12),
            new CityItem("Swakopmund", "swakopmund", 7),
            new CityItem("Walvis Bay", "walvis-bay", 3),
            new CityItem("Online", "online", 20)
        };

        public List<EventCard> FeaturedEvents { get; init; } = new()
        {
            new EventCard(Guid.NewGuid(), "Tech Meetup", DateTimeOffset.Now.AddDays(1), "Windhoek, Namibia", false, 100, "https://placehold.co/600x400", false, 50),
            new EventCard(Guid.NewGuid(), "Art Expo", DateTimeOffset.Now.AddDays(2), "Swakopmund, Namibia", false, 50, "https://placehold.co/600x400", true, null),
            new EventCard(Guid.NewGuid(), "Online Coding Bootcamp", DateTimeOffset.Now.AddDays(3), "Online", true, 200, "https://placehold.co/600x400", false, 100)
        };
        public List<EventCard> WeekendPicks { get; init; } = new()
        {
            new EventCard(Guid.NewGuid(), "Business Brunch", DateTimeOffset.Now.AddDays(4), "Windhoek, Namibia", false, 30, "https://placehold.co/600x400", false, 80),
            new EventCard(Guid.NewGuid(), "Music Festival", DateTimeOffset.Now.AddDays(5), "Walvis Bay, Namibia", false, 500, "https://placehold.co/600x400", true, null)
        };
        public List<EventCard> OnlinePicks { get; init; } = new()
        {
            new EventCard(Guid.NewGuid(), "Remote Design Workshop", DateTimeOffset.Now.AddDays(6), "Online", true, 150, "https://placehold.co/600x400", false, 30)
        };
        public List<EventCard> FreePicks { get; init; } = new()
        {
            new EventCard(Guid.NewGuid(), "Free Yoga Class", DateTimeOffset.Now.AddDays(7), "Windhoek, Namibia", false, 25, "https://placehold.co/600x400", true, null)
        };

        public sealed record CategoryChip(string Name, string Slug);
        public sealed record CityItem(string Name, string Slug, int EventCount);

        public sealed record EventCard(
            Guid Id,
            string Title,
            DateTimeOffset StartLocal,
            string Location,
            bool IsOnline,
            int Capacity,
            string ImageUrl,
            bool IsFree = false,
            decimal? PriceFrom = null)
        {
            public string PriceFromFormatted => PriceFrom is null ? "Free" : $"From N${PriceFrom:0}";
        }
    }
}
