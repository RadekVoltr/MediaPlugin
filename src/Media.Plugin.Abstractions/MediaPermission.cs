namespace Plugin.Media.Abstractions
{
    /// <summary>
    /// Permissions needed 
    /// </summary>
    public enum MediaPermission
    {
        /// <summary>
        /// Android -> Read/Write External Storage
        /// iOS -> Camera and Photo Gallery
        /// </summary>
        Camera,
        /// <summary>
        /// Android -> Read/Write External Storage
        /// iOS -> Photo Gallery
        /// </summary>
        PhotoAlbum
    }
}
