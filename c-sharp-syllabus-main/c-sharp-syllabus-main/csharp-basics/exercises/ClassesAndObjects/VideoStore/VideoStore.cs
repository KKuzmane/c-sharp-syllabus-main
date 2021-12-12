using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        public List<Video> _videoList;

        public VideoStore()
        {
            _videoList = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _videoList.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach (var item in _videoList)
            {
                if(item.Title == title)
                {
                    item.BeingCheckedOut();
                    break;
                }
            }
        }

        public void ReturnedVideo(string title)
        {
            foreach(var item in _videoList)
            {
                if(item.Title == title)
                {
                    item.BeingReturned();
                    break;
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach(var item in _videoList)
            {
                if(item.Title == title)
                {
                    item.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (Video film in _videoList)
            {
                Console.Write(film.ToString());
            }
        }
    }
}
