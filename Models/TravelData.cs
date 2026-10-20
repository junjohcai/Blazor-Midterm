namespace MyBlazorApp.Models; // Change 'MyBlazorApp' to your actual project namespace

public record Journey(string Place, string Title, string Days, string From, string Image, string Alt);

public record Slide(
    string Location, string Kicker, string Title, string Accent, string Description,
    string Image, string Alt, string Theme, string Search, string CollectionTitle,
    string CollectionAccent, List<Journey> Journeys, string FeatureImage,
    string FeatureAlt, string Stat, string StatLabel, string FeatureTitle,
    string FeatureAccent, string FeatureCopy, string JournalImage,
    string JournalAlt, string JournalMeta, string JournalTitle,
    string JournalCopy, string CtaTitle, string CtaCopy
);

public static class TravelRepository
{
    private static string Photo(string id, int width = 1400) => 
        $"https://images.unsplash.com/{id}?auto=format&fit=crop&q=84&w={width}";

    public static List<Slide> GetSlides() => new()
    {
        new Slide(
            Location: "Palawan, Philippines",
            Kicker: "Island escapes · turquoise horizons",
            Title: "Find your place",
            Accent: "in the world.",
            Description: "Thoughtful escapes, rare places, and local stories—curated for people who travel with curiosity.",
            Image: Photo("photo-1618064541372-289bdb6f5b7b", 2200),
            Alt: "A secluded tropical beach and resort seen from above",
            Theme: "theme-tropical",
            Search: "Try Bali, Palawan, or Fiji",
            CollectionTitle: "Barefoot days &",
            CollectionAccent: "island ways.",
            Journeys: new List<Journey>
            {
                new("Coron, Philippines", "Lagoons beyond the map", "7 days", "From $2,640", Photo("photo-1605538108568-7f0d77a214c1"), "White sand and dense palms beside a tropical lagoon"),
                new("Siargao, Philippines", "Slow days under palms", "8 days", "From $2,980", Photo("photo-1661410205208-f401a7d1edc8"), "Palm-fringed beach and island retreat"),
                new("Baa Atoll, Maldives", "Barefoot in the blue", "6 days", "From $4,120", Photo("photo-1706783924603-16fdc3bacb14"), "Aerial view of a tropical island and turquoise ocean")
            },
            FeatureImage: Photo("photo-1669123547602-b85454d7ee84"),
            FeatureAlt: "A secluded villa surrounded by tropical forest",
            Stat: "42",
            StatLabel: "Island experts",
            FeatureTitle: "The art of",
            FeatureAccent: "island time.",
            FeatureCopy: "Move with the tides, eat where the fishermen gather, and discover the quiet coves that never make the guidebooks.",
            JournalImage: Photo("photo-1575999080555-3f7a698dd8d9"),
            JournalAlt: "Island homes and trees beside clear blue water",
            JournalMeta: "Island notes · 6 min",
            JournalTitle: "The last quiet islands of the Philippines",
            JournalCopy: "Hidden coves, family-run stays, and the communities keeping their home beautifully wild.",
            CtaTitle: "Your island is waiting.",
            CtaCopy: "Tell us how you like to travel and we’ll find your perfect stretch of sand."
        ),
        new Slide(
            Location: "Kyoto, Japan",
            Kicker: "Sakura season · ancient rituals",
            Title: "Follow the path",
            Accent: "of wonder.",
            Description: "Temple mornings, quiet tea houses, and a city transformed by blossom—Japan at its most poetic.",
            Image: "https://dynamic-media.tacdn.com/media/photo-o/34/1d/af/f2/caption.jpg?f=webp&w=2400&h=1400",
            Alt: "Traditional streets of Kyoto",
            Theme: "theme-sakura",
            Search: "Try Kyoto, Tokyo, or Nara",
            CollectionTitle: "Between blossoms &",
            CollectionAccent: "timeless rituals.",
            Journeys: new List<Journey>
            {
                new("Kyoto, Japan", "Temples under sakura", "8 days", "From $3,420", Photo("photo-1712554009719-68e5aa9d6ba3"), "People crossing a bridge beneath cherry blossoms"),
                new("Yoshino, Japan", "A thousand shades of pink", "6 days", "From $2,890", Photo("photo-1563021555-6460d86d7a4d"), "Hillside covered in pink cherry blossom trees"),
                new("Nara, Japan", "Gardens of stillness", "7 days", "From $3,180", Photo("photo-1617526762278-ac13883264f6"), "Historic Japanese pagoda among spring foliage")
            },
            FeatureImage: Photo("photo-1617599136989-9d6c7035a0cc"),
            FeatureAlt: "Cherry blossoms framing a traditional Japanese building",
            Stat: "28",
            StatLabel: "Japan insiders",
            FeatureTitle: "Japan in",
            FeatureAccent: "full bloom.",
            FeatureCopy: "Step beyond the famous viewing spots into temple gardens, ceramic studios, and small streets known best by those who live there.",
            JournalImage: Photo("photo-1675151996268-13acbb2d4a10"),
            JournalAlt: "Soft pink blossoms in front of Japanese architecture",
            JournalMeta: "Seasonal guide · 9 min",
            JournalTitle: "How to see sakura beyond the crowds",
            JournalCopy: "A local’s route through lesser-known gardens, riverside walks, and mountain villages in bloom.",
            CtaTitle: "Meet Japan in bloom.",
            CtaCopy: "Let our local experts shape a spring journey full of beauty, ritual, and surprise."
        ),
        new Slide(
            Location: "Sahara, Morocco",
            Kicker: "Desert nights · golden silence",
            Title: "Go where time",
            Accent: "slows down.",
            Description: "Cross ochre dunes, share stories by firelight, and wake to the vast stillness of the Sahara.",
            Image: Photo("photo-1613169620329-6785c004d900", 2200),
            Alt: "A desert camp beneath a deep blue evening sky in Morocco",
            Theme: "theme-desert",
            Search: "Try Marrakech, Merzouga, or Fez",
            CollectionTitle: "Caravan trails &",
            CollectionAccent: "desert tales.",
            Journeys: new List<Journey>
            {
                new("Merzouga, Morocco", "Nights beneath the stars", "6 days", "From $2,340", Photo("photo-1667143297021-a452e55fdfa8"), "Sculpted dunes in the Moroccan Sahara"),
                new("Marrakech, Morocco", "Courtyards & hidden doors", "7 days", "From $2,780", Photo("photo-1553522988-49daec855a59"), "Warm earthen architecture and lanterns in Morocco"),
                new("Erg Chebbi, Morocco", "Across the golden sea", "8 days", "From $3,160", Photo("photo-1565369698461-470cb55ae979"), "A traveller walking across immense desert dunes")
            },
            FeatureImage: Photo("photo-1553522989-6507cc9be820"),
            FeatureAlt: "Lantern-lit desert camp set for an evening gathering",
            Stat: "36",
            StatLabel: "Desert guides",
            FeatureTitle: "Follow the",
            FeatureAccent: "old caravan road.",
            FeatureCopy: "From spice-scented medinas to a night under Saharan stars, travel in the company of storytellers who know every turn.",
            JournalImage: Photo("photo-1675682330063-7e618e7bffaa"),
            JournalAlt: "A rider crossing the Moroccan desert on horseback",
            JournalMeta: "Desert dispatch · 7 min",
            JournalTitle: "What the Sahara sounds like after dark",
            JournalCopy: "Firelight, distant music, and the profound quiet found beyond the last desert road.",
            CtaTitle: "The desert is calling.",
            CtaCopy: "Trade the familiar for medinas, mountain passes, and nights beneath a million stars."
        ),
        new Slide(
            Location: "Bernese Alps, Switzerland",
            Kicker: "Alpine air · lakeside villages",
            Title: "Breathe a little",
            Accent: "deeper.",
            Description: "Mountain railways, mirrored lakes, and footpaths threading through wildflower meadows high above the everyday.",
            Image: Photo("photo-1527668752968-14dc70a27c95", 2200),
            Alt: "Swiss mountain village beneath towering green peaks",
            Theme: "theme-alpine",
            Search: "Try Zermatt, Interlaken, or Lucerne",
            CollectionTitle: "High peaks &",
            CollectionAccent: "clear horizons.",
            Journeys: new List<Journey>
            {
                new("Lauterbrunnen, Switzerland", "The valley of waterfalls", "7 days", "From $3,520", Photo("photo-1607585011081-241d2bacb7de"), "Swiss houses scattered across a green mountain valley"),
                new("Lake Brienz, Switzerland", "Where the mountains meet blue", "6 days", "From $3,180", Photo("photo-1528493366314-e317cd98dd52"), "Aerial view of a Swiss village beside turquoise Lake Brienz"),
                new("Zermatt, Switzerland", "Winter above the clouds", "8 days", "From $4,260", Photo("photo-1593365635194-ebf3e5161a00"), "Snow-covered alpine village beneath white peaks")
            },
            FeatureImage: Photo("photo-1516490701444-1daf45984537"),
            FeatureAlt: "A small Swiss church beneath a dramatic alpine mountain",
            Stat: "31",
            StatLabel: "Alpine hosts",
            FeatureTitle: "Life at a",
            FeatureAccent: "higher altitude.",
            FeatureCopy: "Ride heritage trains, sleep in family chalets, and walk meadow paths with people who have known these mountains all their lives.",
            JournalImage: Photo("photo-1526925528837-813a7961f5c7"),
            JournalAlt: "Still alpine lake surrounded by the Swiss mountain range",
            JournalMeta: "Trail guide · 8 min",
            JournalTitle: "The slow train through Switzerland",
            JournalCopy: "Why the finest way across the Alps is measured in lake views, village stops, and long lunches.",
            CtaTitle: "The mountains are closer.",
            CtaCopy: "Tell us your pace and we’ll create an alpine escape with room to breathe."
        ),
        new Slide(
            Location: "Maasai Mara, Kenya",
            Kicker: "Wild horizons · golden mornings",
            Title: "Wake up to",
            Accent: "the wild.",
            Description: "Dawn game drives, open savanna, and nights beneath a sky untouched by city light—Africa in full scale.",
            Image: Photo("photo-1523805009345-7448845a9e53", 2200),
            Alt: "Giraffe crossing golden Kenyan savanna near an acacia tree",
            Theme: "theme-savanna",
            Search: "Try Maasai Mara, Amboseli, or Laikipia",
            CollectionTitle: "Wild encounters &",
            CollectionAccent: "open skies.",
            Journeys: new List<Journey>
            {
                new("Maasai Mara, Kenya", "In the path of the lion", "7 days", "From $4,380", Photo("photo-1709402606682-400133d92ab2"), "Safari vehicle watching a lion in the Maasai Mara"),
                new("Amboseli, Kenya", "Giants of the grasslands", "6 days", "From $3,920", Photo("photo-1733705940512-87d66e3fcd9c"), "Giraffe walking through a lush Kenyan landscape"),
                new("Laikipia, Kenya", "The great untamed north", "9 days", "From $5,140", Photo("photo-1623743424601-12be3807f99b"), "Zebra standing in the golden grasslands")
            },
            FeatureImage: Photo("photo-1605302596013-fccbe2f06298"),
            FeatureAlt: "Safari vehicle travelling along a remote dirt road",
            Stat: "24",
            StatLabel: "Safari guides",
            FeatureTitle: "Closer to",
            FeatureAccent: "the living world.",
            FeatureCopy: "Track wildlife with expert naturalists, meet conservancy partners, and stay in camps where every visit helps protect the land.",
            JournalImage: Photo("photo-1517846875602-2371528547d4"),
            JournalAlt: "Hot air balloons floating above the Kenyan wilderness",
            JournalMeta: "Safari notes · 10 min",
            JournalTitle: "The Mara from the sky at first light",
            JournalCopy: "A balloon journey over winding rivers, migrating herds, and an endless gold horizon.",
            CtaTitle: "Answer the call of the wild.",
            CtaCopy: "Our safari specialists will design a journey with wildlife, wonder, and a lighter footprint."
        ),
        
    };
}