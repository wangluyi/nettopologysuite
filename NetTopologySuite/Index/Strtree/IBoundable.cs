namespace GisSharpBlog.NetTopologySuite.Index.Strtree
{
    /// <summary>
    /// A spatial object in an AbstractStrTree.
    /// </summary>
    public interface IBoundable<TBounds>
    {
        /// <summary> 
        /// Returns a representation of space that encloses this Boundable, preferably
        /// not much bigger than this Boundable's boundary yet fast to test for intersection
        /// with the bounds of other Boundables. The class of object returned depends
        /// on the subclass of AbstractStrTree.
        /// </summary>
        /// <returns> 
        /// An Envelope (for STRtrees), an Interval (for SIRtrees), or other object
        /// (for other subclasses of AbstractStrTree).
        /// </returns>
        TBounds Bounds { get; }
    }
}