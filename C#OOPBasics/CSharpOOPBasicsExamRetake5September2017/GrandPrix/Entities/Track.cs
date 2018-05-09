public class Track
{
    public Track(int lapsNumber, int trackLength)
    {
        this.LapsNumber = lapsNumber;
        this.TrackLength = trackLength;
    }

    public int LapsNumber { get; set; }

    public int TrackLength { get; set; }
}