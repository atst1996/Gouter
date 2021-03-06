﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Gouter
{
    internal class AlbumPlaylist : IPlaylist
    {
        bool IPlaylist.IsAutoGenerated { get; } = true;

        public string Name { get; }

        public AlbumPlaylist(AlbumInfo albumInfo)
        {
            this.Album = albumInfo;
            this.Tracks = new NotifiableCollection<TrackInfo>();

            this.Name = albumInfo.Name;

            BindingOperations.EnableCollectionSynchronization(this.Tracks, new object());
        }

        public AlbumInfo Album { get; }

        public NotifiableCollection<TrackInfo> Tracks { get; }

        IList<TrackInfo> IPlaylist.Tracks => this.Tracks;
    }
}
