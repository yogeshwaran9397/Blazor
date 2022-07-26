namespace BlazorSample.Pages.Movies
{
    public class Movies
    {
        public int dMovieID = 0;
        public string strMovieName = "";
        public string strMovieRelDate = "";
        public string strMovieLabel = "";

        public Movies(int dMovieID, string strMovieName, string strMovieRelDate, string strMovieLabel)
        {
            this.dMovieID = dMovieID;
            this.strMovieName = strMovieName;
            this.strMovieRelDate = strMovieRelDate;
            this.strMovieLabel = strMovieLabel;
        }
    }
}
