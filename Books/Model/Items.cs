using System;

namespace Books
{
	public class Items
	{
		public VolumeInfo VolumeInfo { get; set; }
        public string Id { get; set; }
        public string SelfLink { get; set; }

        public Items( VolumeInfo volumeInfo, string id, string selflink)
		{
			VolumeInfo = volumeInfo;
			Id = id;
			SelfLink = selflink;
		}

       
    }
}

