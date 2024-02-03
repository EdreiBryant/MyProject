

namespace PC_PartsReview_Website.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string PcPartEndpoint = $"{Prefix}/PcParts";
        public static readonly string RatingEndpoint = $"{Prefix}/Ratings";
        public static readonly string ReviewEndpoint = $"{Prefix}/Reviews";
    }
}
