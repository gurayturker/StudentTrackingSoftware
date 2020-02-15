namespace StudentTrackingSoftware.UI.Win.Interfaces
{
    public interface IStatusBarShortCut:IStatusBarDescription
    {
        string statusBarShortCut { get; set; }
        string statusBarShortCutDescription { get; set; }
    }
}
